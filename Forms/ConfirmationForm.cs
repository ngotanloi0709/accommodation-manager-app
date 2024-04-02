using MaterialSkin.Controls;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms
{
    public sealed partial class ConfirmationForm : MaterialForm
    {
        public ConfirmationForm(string message)
        {
            InitializeComponent();
            Text = "Thông báo";
            labelMessage.Text = message;
        }

        private void buttonYes_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void buttonNo_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }
    }
}