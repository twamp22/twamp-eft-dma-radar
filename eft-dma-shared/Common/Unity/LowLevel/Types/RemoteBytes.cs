using eft_dma_shared.Common.DMA;
using eft_dma_shared.Common.Misc;
using eft_dma_shared.Common.Unity.LowLevel.Hooks;

namespace eft_dma_shared.Common.Unity.LowLevel.Types
{
    public sealed class RemoteBytes : IDisposable
    {
        public static implicit operator ulong(RemoteBytes x) => x._pmem;

        private readonly uint _size;
        private ulong _pmem;

        public RemoteBytes(int size)
        {
            _size = MemDMABase.AlignLength((uint)size);
            _pmem = NativeMethods.AllocBytes(_size);
            _pmem.ThrowIfInvalidVirtualAddress();
        }

        public RemoteBytes(IMonoType data)
        {
            _size = MemDMABase.AlignLength((uint)data.Data.Length);
            _pmem = NativeMethods.AllocBytes(_size);
            _pmem.ThrowIfInvalidVirtualAddress();
        }

        public void Dispose()
        {
            ulong pmem = Interlocked.Exchange(ref _pmem, 0);
            if (pmem != 0x0)
            {
                NativeMethods.FreeBytes(pmem);
            }
        }
    }
}
