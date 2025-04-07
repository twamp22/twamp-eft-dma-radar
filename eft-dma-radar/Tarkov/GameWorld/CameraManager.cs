﻿using eft_dma_shared.Common.Misc;
using eft_dma_shared.Common.DMA;
using eft_dma_shared.Common.Unity;
using eft_dma_shared.Common.Unity.Collections;
using eft_dma_shared.Common.DMA.ScatterAPI;
using eft_dma_radar.Tarkov.EFTPlayer;

namespace eft_dma_radar.Tarkov.GameWorld
{
    public sealed class CameraManager : CameraManagerBase
    {
        private static ulong _opticCameraManagerField;

        /// <summary>
        /// FPS Camera (unscoped).
        /// </summary>
        public override ulong FPSCamera { get; }
        /// <summary>
        /// Optic Camera (ads/scoped).
        /// </summary>
        public override ulong OpticCamera { get; }

        public CameraManager() : base()
        {
            var ocmContainer = Memory.ReadPtr(_opticCameraManagerField + Offsets.OpticCameraManagerContainer.Instance, false);
            var fps = Memory.ReadPtr(ocmContainer + Offsets.OpticCameraManagerContainer.FPSCamera, false);
            if (ObjectClass.ReadName(fps, 32, false) != "Camera")
                throw new ArgumentOutOfRangeException(nameof(fps));
            FPSCamera = Memory.ReadPtr(fps + 0x10, false);
            var ocm = Memory.ReadPtr(ocmContainer + Offsets.OpticCameraManagerContainer.OpticCameraManager, false);
            var optic = Memory.ReadPtr(ocm + Offsets.OpticCameraManager.Camera, false);
            if (ObjectClass.ReadName(optic, 32, false) != "Camera")
                throw new ArgumentOutOfRangeException(nameof(optic));
            OpticCamera = Memory.ReadPtr(optic + 0x10, false);
        }

        static CameraManager()
        {
            MemDMABase.GameStopped += MemDMA_GameStopped;
        }

        /// <summary>
        /// Initialize the Camera Manager static assets on game startup.
        /// </summary>
        public static void Initialize()
        {
            _opticCameraManagerField = MonoLib.MonoClass.Find("Assembly-CSharp", ClassNames.OpticCameraManagerContainer.ClassName, out _).GetStaticFieldData();
            _opticCameraManagerField.ThrowIfInvalidVirtualAddress();
        }

        private static void MemDMA_GameStopped(object sender, EventArgs e)
        {
            _opticCameraManagerField = default;
        }

        /// <summary>
        /// Checks if the Optic Camera is active and there is an active scope zoom level greater than 1.
        /// </summary>
        /// <returns>True if scoped in, otherwise False.</returns>
        private bool CheckIfScoped(LocalPlayer localPlayer)
        {
            try
            {
                if (localPlayer is null)
                    return false;
                if (OpticCameraActive)
                {
                    var opticsPtr = Memory.ReadPtr(localPlayer.PWA + Offsets.ProceduralWeaponAnimation._optics);
                    using var optics = MemList<MemPointer>.Get(opticsPtr);
                    if (optics.Count > 0)
                    {
                        var pSightComponent = Memory.ReadPtr(optics[0] + Offsets.SightNBone.Mod);
                        var sightComponent = Memory.ReadValue<SightComponent>(pSightComponent);

                        if (sightComponent.ScopeZoomValue != 0f)
                            return sightComponent.ScopeZoomValue > 1f;
                        return sightComponent.GetZoomLevel() > 1f; // Make sure we're actually zoomed in
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                LoneLogging.WriteLine($"CheckIfScoped() ERROR: {ex}");
                return false;
            }
        }

        /// <summary>
        /// Executed on each Realtime Loop.
        /// </summary>
        /// <param name="index">Scatter read index dedicated to this object.</param>
        public void OnRealtimeLoop(ScatterReadIndex index, /* Can Be Null */ LocalPlayer localPlayer)
        {
            IsADS = localPlayer?.CheckIfADS() ?? false;
            IsScoped = IsADS && CheckIfScoped(localPlayer);
            ulong vmAddr = IsADS && IsScoped
                ? OpticCamera + UnityOffsets.Camera.ViewMatrix
                : FPSCamera + UnityOffsets.Camera.ViewMatrix;
            index.AddEntry<Matrix4x4>(0, vmAddr); // View Matrix
            index.Callbacks += x1 =>
            {
                ref Matrix4x4 vm = ref x1.GetRef<Matrix4x4>(0);
                if (!Unsafe.IsNullRef(ref vm))
                    _viewMatrix.Update(ref vm);
            };
            if (IsScoped)
            {
                index.AddEntry<float>(1, FPSCamera + UnityOffsets.Camera.FOV); // FOV
                index.AddEntry<float>(2, FPSCamera + UnityOffsets.Camera.AspectRatio); // Aspect
                index.Callbacks += x2 =>
                {
                    if (x2.TryGetResult<float>(1, out var fov))
                        _fov = fov;
                    if (x2.TryGetResult<float>(2, out var aspect))
                        _aspect = aspect;
                };
            }
        }

        [StructLayout(LayoutKind.Explicit, Pack = 1)]
        private readonly ref struct SightComponent // (Type: EFT.InventoryLogic.SightComponent)

        {
            [FieldOffset((int)Offsets.SightComponent._template)] private readonly ulong pSightInterface;

            [FieldOffset((int)Offsets.SightComponent.ScopesSelectedModes)] private readonly ulong pScopeSelectedModes;

            [FieldOffset((int)Offsets.SightComponent.SelectedScope)] private readonly int SelectedScope;

            [FieldOffset((int)Offsets.SightComponent.ScopeZoomValue)] public readonly float ScopeZoomValue;

            public readonly float GetZoomLevel()
            {
                using var zoomArray = SightInterface.Zooms;
                if (SelectedScope >= zoomArray.Count || SelectedScope is < 0 or > 10)
                    return -1.0f;
                using var selectedScopeModes = MemArray<int>.Get(pScopeSelectedModes, false);
                int selectedScopeMode = SelectedScope >= selectedScopeModes.Count ?
                    0 : selectedScopeModes[SelectedScope];
                ulong zoomAddr = zoomArray[SelectedScope] + MemArray<float>.ArrBaseOffset + (uint)selectedScopeMode * 0x4;

                float zoomLevel = Memory.ReadValue<float>(zoomAddr, false);
                if (zoomLevel.IsNormalOrZero() && zoomLevel is >= 0f and < 100f)
                    return zoomLevel;

                return -1.0f;
            }

            public readonly SightInterface SightInterface =>
                Memory.ReadValue<SightInterface>(pSightInterface);
        }

        [StructLayout(LayoutKind.Explicit, Pack = 1)]
        private readonly ref struct SightInterface // _template (Type: -.GInterfaceBB26)

        {
            [FieldOffset((int)Offsets.SightInterface.Zooms)] private readonly ulong pZooms;

            public readonly MemArray<ulong> Zooms =>
                MemArray<ulong>.Get(pZooms);
        }
    }
}