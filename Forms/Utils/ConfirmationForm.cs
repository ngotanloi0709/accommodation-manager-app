using MaterialSkin.Controls;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms
{
    public sealed partial class ConfirmationForm : MaterialForm
    {
        public ConfirmationForm(string message)
        {
            InitializeComponent();
            this.Text = "Notice";
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
    }
}