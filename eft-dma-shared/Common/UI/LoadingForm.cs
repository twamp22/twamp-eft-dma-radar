namespace eft_dma_shared.Common.UI
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
            label_FormMessage.Left = (this.ClientSize.Width - label_FormMessage.Width) / 2;
            label_FormMessage.Top = (this.ClientSize.Height - label_FormMessage.Height) / 2;
            this.CenterToScreen();
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
