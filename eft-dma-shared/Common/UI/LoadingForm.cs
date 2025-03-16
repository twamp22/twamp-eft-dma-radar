using System.ComponentModel;

namespace eft_dma_shared.Common.UI
{
    public partial class LoadingForm : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int PercentComplete { get; private set; }

        public LoadingForm()
        {
            InitializeComponent();
            zzzCenter();
            this.CenterToScreen();
        }

        public void UpdateStatus(string text, int percentComplete)
        {
            this.Invoke(() =>
            {
                PercentComplete = percentComplete;
                label_ProgressText.Text = text;
                progressBar1.Value = percentComplete;
                zzzCenter();
            });
        }

        private void zzzCenter()
        {
            flowLayoutPanel_Progress.Left = (this.ClientSize.Width - flowLayoutPanel_Progress.Width) / 2;
            flowLayoutPanel_Progress.Top = (this.ClientSize.Height - flowLayoutPanel_Progress.Height) / 2;
        }

        public static LoadingForm Create()
        {
            LoadingForm form = null;
            var t = new Thread(() =>
            {
                form = new LoadingForm();
                form.ShowDialog();
            })
            { IsBackground = true };
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            while (form is null) // Wait for the form to be created
                Thread.SpinWait(10);
            return form;
        }
    }
}
