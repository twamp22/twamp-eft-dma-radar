using eft_dma_shared.Common.Unity.LowLevel;
using SkiaSharp;
using System.Text.Json.Serialization;

namespace eft_dma_shared.Common.Misc.Config
{
    public sealed class ChamsConfig
    {
        /// <summary>
        /// True if this feature is enabled.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; } = false;

        /// <summary>
        /// Last Chams Mode that the player set.
        /// </summary>
        [JsonPropertyName("mode")]
        public ChamsManager.ChamsMode Mode { get; set; } = ChamsManager.ChamsMode.Basic;

        /// <summary>
        /// Visible color for vischeck chams.
        /// </summary>
        [JsonPropertyName("visColor")]
        public string VisibleColor { get; set; } = SKColor.Parse("FF32CD32").ToString(); // LimeGreen
        
        /// <summary>
        /// Invisible color for vischeck chams.
        /// </summary>
        [JsonPropertyName("invisColor")]
        public string InvisibleColor { get; set; } = SKColor.Parse("FFFF1493").ToString(); // Pink
        
        /// <summary>
        /// Visible color for vischeck chams.
        /// </summary>
        [JsonPropertyName("visColorPMC")]
        public string VisibleColorPMC { get; set; } = SKColor.Parse("FF1E90FF").ToString(); // Neon Blue
        
        /// <summary>
        /// Invisible color for vischeck chams.
        /// </summary>
        [JsonPropertyName("invisColorPMC")]
        public string InvisibleColorPMC { get; set; } = SKColor.Parse("FFFF0000").ToString(); // Red

    }
}
