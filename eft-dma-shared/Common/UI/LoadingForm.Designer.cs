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
        if (disposing)
        {
            this.Invoke(() => this.Close());
        }
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
            flowLayoutPanel_Progress = new FlowLayoutPanel();
            label_ProgressText = new Label();
            progressBar1 = new ProgressBar();
            flowLayoutPanel_Progress.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel_Progress
            // 
            flowLayoutPanel_Progress.Anchor = AnchorStyles.Top;
            flowLayoutPanel_Progress.AutoSize = true;
            flowLayoutPanel_Progress.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel_Progress.Controls.Add(label_ProgressText);
            flowLayoutPanel_Progress.Controls.Add(progressBar1);
            flowLayoutPanel_Progress.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel_Progress.Location = new Point(118, 148);
            flowLayoutPanel_Progress.Name = "flowLayoutPanel_Progress";
            flowLayoutPanel_Progress.Size = new Size(431, 49);
            flowLayoutPanel_Progress.TabIndex = 0;
            // 
            // label_ProgressText
            // 
            label_ProgressText.Anchor = AnchorStyles.None;
            label_ProgressText.AutoSize = true;
            label_ProgressText.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_ProgressText.Location = new Point(215, 0);
            label_ProgressText.Name = "label_ProgressText";
            label_ProgressText.Size = new Size(0, 20);
            label_ProgressText.TabIndex = 1;
            label_ProgressText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.None;
            progressBar1.Location = new Point(3, 23);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(425, 23);
            progressBar1.TabIndex = 0;
            // 
            // LoadingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(flowLayoutPanel_Progress);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoadingForm";
            ShowInTaskbar = false;
            Text = "Loading";
            TopMost = true;
            flowLayoutPanel_Progress.ResumeLayout(false);
            flowLayoutPanel_Progress.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel_Progress;
        private Label label_ProgressText;
        private ProgressBar progressBar1;
    }
}