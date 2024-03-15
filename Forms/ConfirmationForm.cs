using MaterialSkin.Controls;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms
{
    public sealed partial class ConfirmationForm : MaterialForm
    {
        public ConfirmationForm(string message)
        {
            InitializeComponent();
            this.Text = "Thông báo";
            this.labelMessage.Text = message;
        }

        private void buttonYes_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void buttonNo_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
        
        // protected override void OnFormClosing(FormClosingEventArgs e)
        // {
        //     base.OnFormClosing(e);
        //     if (this.DialogResult == DialogResult.None)
        //     {
        //         this.DialogResult = DialogResult.No;
        //     }
        // }
    }
}