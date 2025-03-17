using eft_dma_shared.Common.Misc;
using eft_dma_radar.Tarkov.EFTPlayer;
using eft_dma_radar.Tarkov.Features;
using eft_dma_radar.UI.Misc;
using eft_dma_shared.Common.DMA.ScatterAPI;
using eft_dma_shared.Common.Features;

namespace eft_dma_radar.Tarkov.Features.MemoryWrites
{
    public sealed class WideLean : MemWriteFeature<WideLean>
    {
        public static EWideLeanDirection Direction = EWideLeanDirection.Off;
        private bool _set = false;

        public override bool Enabled
        {
            get => MemWrites.Config.WideLean.Enabled;
            set => MemWrites.Config.WideLean.Enabled = value;
        }

        protected override TimeSpan Delay => TimeSpan.FromMilliseconds(100);


        /// <summary>
        /// Wide Lean Config.
        /// </summary>
        public static WideLeanConfig Config { get; } = MemWrites.Config.WideLean;

        public override void TryApply(ScatterWriteHandle writes)
        {
            try
            {
                if (Memory.LocalPlayer is LocalPlayer localPlayer)
                {
                    var dir = Direction;
                    if (Enabled && dir is not EWideLeanDirection.Off && !_set)
                    {
                        float m100 = 50f;
                        switch (dir)
                        {
                            case EWideLeanDirection.Left:
                                var up1 = new Vector3(0f, 0f, m100/2);
                                writes.AddValueEntry(localPlayer.PWA + Offsets.ProceduralWeaponAnimation.PositionZeroSum, ref up1);
                                break;
                            case EWideLeanDirection.Right:
                                var up2 = new Vector3(0f, 0f, m100);
                                writes.AddValueEntry(localPlayer.PWA + Offsets.ProceduralWeaponAnimation.PositionZeroSum, ref up2);
                                break;
                            case EWideLeanDirection.Up:
                                var up3 = new Vector3(0f, 0f, m100*2);
                                writes.AddValueEntry(localPlayer.PWA + Offsets.ProceduralWeaponAnimation.PositionZeroSum, ref up3);
                                break;
                            default:
                                throw new InvalidOperationException("Invalid wide lean option");
                        }
                        writes.Callbacks += () =>
                        {
                            _set = true;
                            LoneLogging.WriteLine("Wide Lean [On]");
                        };
                    }
                    else if (_set && dir is EWideLeanDirection.Off)
                    {
                        var off = Vector3.Zero;
                        writes.AddValueEntry(localPlayer.PWA + Offsets.ProceduralWeaponAnimation.PositionZeroSum, ref off);
                        writes.Callbacks += () =>
                        {
                            _set = false;
                            LoneLogging.WriteLine("Wide Lean [Off]");
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                Direction = EWideLeanDirection.Off;
                LoneLogging.WriteLine($"Wide Lean [ERROR] {ex}");
            }
        }

        public override void OnRaidStart()
        {
            _set = default;
        }

        public enum EWideLeanDirection
        {
            Off,
            Left,
            Right,
            Up
        }
    }
}
