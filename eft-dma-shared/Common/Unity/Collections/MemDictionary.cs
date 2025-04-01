﻿using eft_dma_shared.Common.Misc.Commercial;
using eft_dma_shared.Common.Misc.Pools;
using System.Runtime.InteropServices;

namespace eft_dma_shared.Common.Unity.Collections
{
    /// <summary>
    /// DMA Wrapper for a C# Dictionary
    /// Must initialize before use. Must dispose after use.
    /// </summary>
    /// <typeparam name="TKey">Key Type between 1-8 bytes.</typeparam>
    /// <typeparam name="TValue">Value Type between 1-8 bytes.</typeparam>
    public sealed class MemDictionary<TKey, TValue> : SharedArray<MemDictionary<TKey, TValue>.MemDictEntry>, IPooledObject<MemDictionary<TKey, TValue>>
    where TKey : unmanaged
        where TValue : unmanaged
    {
        public const uint CountOffset = 0x40;
        public const uint EntriesOffset = 0x18;
        public const uint EntriesStartOffset = 0x20;

        /// <summary>
        /// Get a MemDictionary <typeparamref name="TKey"/>, <typeparamref name="TValue"/> from the object pool.
        /// </summary>
        /// <param name="addr">Base Address for this collection.</param>
        /// <param name="useCache">Perform cached reading.</param>
        /// <returns>Rented MemDictionary <typeparamref name="TKey"/>/<typeparamref name="TValue"/> instance.</returns>
        public static MemDictionary<TKey, TValue> Get(ulong addr, bool useCache = true)
        {
            var dict = IPooledObject<MemDictionary<TKey, TValue>>.Rent();
            dict.Initialize(addr, useCache);
            return dict;
        }

        /// <summary>
        /// Initializer for Unity Dictionary
        /// </summary>
        /// <param name="addr">Base Address for this collection.</param>
        /// <param name="useCache">Perform cached reading.</param>
        private void Initialize(ulong addr, bool useCache = true)
        {
            try
            {
                var count = Memory.ReadValue<int>(addr + CountOffset, useCache);
                ArgumentOutOfRangeException.ThrowIfGreaterThan(count, 16384, nameof(count));
                Initialize(count);
                if (count == 0)
                    return;
                var dictBase = Memory.ReadPtr(addr + EntriesOffset, useCache) + EntriesStartOffset;
                Memory.ReadBuffer(dictBase, Span, useCache); // Single read into mem buffer
            }
            catch
            {
                Dispose();
                throw;
            }
        }

        [Obsolete("You must rent this object via IPooledObject!")]
        public MemDictionary() : base() { }

        protected override void Dispose(bool disposing)
        {
            IPooledObject<MemDictionary<TKey, TValue>>.Return(this);
        }

        [StructLayout(LayoutKind.Sequential, Pack = 8)]
        public readonly struct MemDictEntry
        {
            private readonly ulong _pad00;
            public readonly TKey Key;
            public readonly TValue Value;
        }
    }
}
