﻿using eft_dma_shared.Common.ESP;
using eft_dma_shared.Common.Misc;
using SkiaSharp;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace eft_dma_shared.Common.Unity
{
    public abstract class CameraManagerBase
    {
        /// <summary>
        /// FPS Camera (unscoped).
        /// </summary>
        public virtual ulong FPSCamera => throw new NotImplementedException(nameof(FPSCamera));
        /// <summary>
        /// Optic Camera (ads/scoped).
        /// </summary>
        public virtual ulong OpticCamera => throw new NotImplementedException(nameof(OpticCamera));
        /// <summary>
        /// True if Optic Camera is currently active.
        /// </summary>
        protected bool OpticCameraActive => Memory.ReadValue<bool>(OpticCamera + MonoBehaviour.IsAddedOffset, false);
        public bool isOpticCameraActive => OpticCameraActive;
        protected CameraManagerBase()
        {
        }


        #region Static Interfaces

        private const int VIEWPORT_TOLERANCE = 800;
        private static readonly Lock _viewportSync = new();

        /// <summary>
        /// True if ESP is currently rendering.
        /// </summary>
        public static bool EspRunning { get; set; }
        /// <summary>
        /// Game Viewport (Monitor Coordinates).
        /// </summary>
        public static Rectangle Viewport { get; private set; }
        /// <summary>
        /// Center of Game Viewport.
        /// </summary>
        public static SKPoint ViewportCenter => new SKPoint(Viewport.Width / 2f, Viewport.Height / 2f);
        /// <summary>
        /// True if LocalPlayer's Optic Camera is active (scope).
        /// </summary>
        public static bool IsScoped { get; protected set; }
        /// <summary>
        /// True if LocalPlayer is Aiming Down Sights (any sight/scope/irons).
        /// </summary>
        public static bool IsADS { get; protected set; }

        protected static float _fov;
        protected static float _aspect;
        protected static readonly ViewMatrix _viewMatrix = new();
        public static ViewMatrix ViewMatrixWeb => _viewMatrix;

        /// <summary>
        /// Update the Viewport Dimensions for Camera Calculations.
        /// </summary>
        public static void UpdateViewportRes()
        {
            lock (_viewportSync)
            {
                Viewport = new Rectangle(0, 0, SharedProgram.Config.MonitorWidth, SharedProgram.Config.MonitorHeight);
            }
        }


        /// <summary>
        /// Translates 3D World Positions to 2D Screen Positions.
        /// </summary>
        /// <param name="worldPos">Entity's world position.</param>
        /// <param name="scrPos">Entity's screen position.</param>
        /// <param name="onScreenCheck">Check if the screen positions are 'on screen'. Returns false if off screen.</param>
        /// <returns>True if successful, otherwise False.</returns>
        public static bool WorldToScreen(ref Vector3 worldPos, out SKPoint scrPos, bool onScreenCheck = false, bool useTolerance = false)
        {
            float w = Vector3.Dot(_viewMatrix.Translation, worldPos) + _viewMatrix.M44; // Transposed

            if (w < 0.098f)
            {
                scrPos = default;
                return false;
            }

            float x = Vector3.Dot(_viewMatrix.Right, worldPos) + _viewMatrix.M14; // Transposed
            float y = Vector3.Dot(_viewMatrix.Up, worldPos) + _viewMatrix.M24; // Transposed

            if (IsScoped)
            {
                float angleRadHalf = (MathF.PI / 180f) * _fov * 0.5f;
                float angleCtg = MathF.Cos(angleRadHalf) / MathF.Sin(angleRadHalf);

                x /= angleCtg * _aspect * 0.5f;
                y /= angleCtg * 0.5f;
            }

            var center = ViewportCenter;
            scrPos = new()
            {
                X = center.X * (1f + x / w),
                Y = center.Y * (1f - y / w)
            };
            if (onScreenCheck)
            {
                int left = useTolerance ? Viewport.Left - VIEWPORT_TOLERANCE : Viewport.Left;
                int right = useTolerance ? Viewport.Right + VIEWPORT_TOLERANCE : Viewport.Right;
                int top = useTolerance ? Viewport.Top - VIEWPORT_TOLERANCE : Viewport.Top;
                int bottom = useTolerance ? Viewport.Bottom + VIEWPORT_TOLERANCE : Viewport.Bottom;
                // Check if the screen position is within the screen boundaries
                if (scrPos.X < left || scrPos.X > right ||
                    scrPos.Y < top || scrPos.Y > bottom)
                {
                    scrPos = default;
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Returns the FOV Magnitude (Length) between a point, and the center of the screen.
        /// </summary>
        /// <param name="point">Screen point to calculate FOV Magnitude of.</param>
        /// <returns>Screen distance from the middle of the screen (FOV Magnitude).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float GetFovMagnitude(SKPoint point)
        {
            return Vector2.Distance(ViewportCenter.AsVector2(), point.AsVector2());
        }
        #endregion
    }
}