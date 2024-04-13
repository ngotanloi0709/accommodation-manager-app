using System.Windows.Forms;
using MaterialSkin.Controls;

namespace AccommodationManagerApp.Forms
{
    public partial class BaseForm : MaterialForm {
        protected static string defaultMail = "user@email.com";
        public BaseForm() {
            InitializeComponent();
            DoubleBuffered = true;
            SetUpUi();
            Icon = Properties.Resources.app_icon;
        }
        protected void SetUpUi()
        {
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
