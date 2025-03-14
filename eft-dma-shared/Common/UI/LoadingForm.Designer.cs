namespace eft_dma_shared.Common.UI
{
    partial class LoadingForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            label_FormMessage = new Label();
            SuspendLayout();
            // 
            // label_FormMessage
            // 
            label_FormMessage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label_FormMessage.AutoSize = true;
            label_FormMessage.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_FormMessage.Location = new Point(65, 148);
            label_FormMessage.Name = "label_FormMessage";
            label_FormMessage.Size = new Size(499, 64);
            label_FormMessage.TabIndex = 0;
            label_FormMessage.Text = "Starting DMA Connection and Loading Assets\r\nPlease Wait...";
            label_FormMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoadingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(label_FormMessage);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoadingForm";
            ShowInTaskbar = false;
            Text = "Loading";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
    private Label label_FormMessage;
}
}