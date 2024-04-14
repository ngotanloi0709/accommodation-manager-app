using System.Windows.Forms;
using MaterialSkin.Controls;

namespace AccommodationManagerApp.Forms
{
    public partial class BaseForm : MaterialForm {
        protected const string DefaultMail = "user@email.com";

        protected BaseForm() {
            InitializeComponent();
            DoubleBuffered = true;
            SetUpUi();
            Icon = Properties.Resources.app_icon;
        }

        private void SetUpUi()
        {
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.None;
            SizeGripStyle = SizeGripStyle.Hide;
        }
    }
}
