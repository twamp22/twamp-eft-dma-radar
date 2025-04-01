using eft_dma_radar.Tarkov.EFTPlayer;
using eft_dma_radar.Tarkov.Loot;
using eft_dma_radar.UI.Radar;
using eft_dma_shared.Common.Misc;
using eft_dma_shared.Common.Misc.Data;
using SkiaSharp;
using System.Text;

namespace eft_dma_radar.UI.SKWidgetControl
{
    public sealed class LootInfoWidget : SKWidget
    {
        private const int MaxVisibleItems = 15;  // ✅ Limit the visible loot to 15
        private int _scrollOffset = 0;  // ✅ Track scroll position
        private LootItem selectedLoot;

        public LootInfoWidget(SKGLControl parent, SKRect location, bool minimized, float scale)
            : base(parent, "Loot Info", new SKPoint(location.Left, location.Top),
                new SKSize(location.Width, location.Height), scale, false)
        {
            Minimized = minimized;
            SetScaleFactor(scale);
        }

        /// <summary>
        /// All Filtered Loot on the map (Grouped by Position).
        /// </summary>
        private static IEnumerable<(LootItem, int)> Loot =>
            Memory.Loot?.FilteredLoot
                ?.Where(item => item is not LootCorpse && item is not QuestItem)
                .GroupBy(item => item.Position)
                .Select(group => (group.First(), group.Count()))
                .OrderByDescending(entry => entry.Item1.Price)
                ?? Enumerable.Empty<(LootItem, int)>();

        public void SelectLoot(LootItem item)
        {
            selectedLoot = item;
        }

        public LootItem GetSelectedLoot()
        {
            return selectedLoot;
        }

        internal static SKPaint TextPaint { get; } = new()
        {
            SubpixelText = true,
            Color = SKColors.White,
            IsStroke = false,
            TextSize = 12,
            TextEncoding = SKTextEncoding.Utf8,
            IsAntialias = true,
            Typeface = SKTypeface.FromFamilyName("Consolas"),
            FilterQuality = SKFilterQuality.High
        };

        public void Draw(SKCanvas canvas, Player localPlayer, SKPoint mousePosition, bool mouseClicked)
        {
            if (Minimized)
            {
                Draw(canvas);
                return;
            }

            var lootItems = Loot.ToList();
            var lootCount = lootItems.Count;

            // ✅ Adjust scrolling bounds
            int maxScrollOffset = Math.Max(0, lootCount - MaxVisibleItems);
            _scrollOffset = Math.Clamp(_scrollOffset, 0, maxScrollOffset);
            var visibleLoot = lootItems.Skip(_scrollOffset).Take(MaxVisibleItems);

            var sb = new StringBuilder();

            // Table headers
            sb.AppendFormat("{0,-18}", "Name")
                .AppendFormat("{0,-8}", "Qty")
                .AppendFormat("{0,-8}", "Price")
                .AppendFormat("{0,-8}", "  Dist")
                .AppendLine();

            var drawPt = new SKPoint(ClientRectangle.Left + 5, ClientRectangle.Top + 20);
            LootItem hoveredItem = null;
            float textHeight = TextPaint.TextSize * 1.2f;

            foreach (var (item, count) in visibleLoot)
            {
                string name = item.ShortName;
                string quantity = count.ToString();

                // ✅ Round price to nearest hundred & add ₽ symbol
                int price = (item.Price / 1000);

                int dist = (int)Vector3.Distance(item.Position, localPlayer.Position);

                sb.AppendFormat("{0,-18}", name)
                    .AppendFormat("{0,-8}", quantity)
                    .AppendFormat("{0,-8}", $"{price}K")
                    .AppendFormat("{0,-8:F1}", $"  {dist}m")
                    .AppendLine();

                // **Improve mouse hit detection**
                var itemRect = new SKRect(
                    drawPt.X, drawPt.Y,
                    drawPt.X + 250, drawPt.Y + textHeight
                );

                if (itemRect.Contains(mousePosition))
                {
                    hoveredItem = item;

                    if (mouseClicked)
                    {
                        if (selectedLoot == item)
                            selectedLoot = null;
                        else
                            selectedLoot = item;
                    }
                }

                drawPt.Y += textHeight;
            }


            var data = sb.ToString().Split(Environment.NewLine);
            var lineSpacing = TextPaint.FontSpacing;
            var maxLength = data.Max(x => TextPaint.MeasureText(x));
            var pad = 2.5f * ScaleFactor;

            Size = new SKSize(maxLength + pad, data.Length * lineSpacing + pad);
            Location = Location;
            Draw(canvas);

            drawPt = new SKPoint(ClientRectangle.Left + pad, ClientRectangle.Top + lineSpacing / 2 + pad);
            canvas.DrawText($"Total Loot: {lootCount}", drawPt, TextPaint);
            drawPt.Y += lineSpacing;

            foreach (var line in data)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    var color = (hoveredItem != null && line.Contains(hoveredItem.ShortName)) ? SKColors.Yellow : SKColors.White;
                    var textPaint = new SKPaint
                    {
                        SubpixelText = TextPaint.SubpixelText,
                        Color = color,
                        IsStroke = TextPaint.IsStroke,
                        TextSize = TextPaint.TextSize,
                        TextEncoding = TextPaint.TextEncoding,
                        IsAntialias = TextPaint.IsAntialias,
                        Typeface = TextPaint.Typeface,
                        FilterQuality = TextPaint.FilterQuality
                    };
                    canvas.DrawText(line, drawPt, textPaint);
                    drawPt.Y += textHeight;
                }
            }
        }

        public bool IsMouseOverWidget(SKPoint mousePosition)
        {
            return new SKRect(ClientRectangle.Left, ClientRectangle.Top, ClientRectangle.Right, ClientRectangle.Bottom)
                .Contains(mousePosition);
        }

        public void OnMouseScroll(int delta)
        {
            _scrollOffset += delta > 0 ? -1 : 1;
            _scrollOffset = Math.Clamp(_scrollOffset, 0, Math.Max(0, Loot.Count() - MaxVisibleItems));
        }

        public override void SetScaleFactor(float newScale)
        {
            base.SetScaleFactor(newScale);
            TextPaint.TextSize = 12 * newScale;
        }
    }
}
