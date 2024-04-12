using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
namespace AccommodationManagerApp.Forms
{
    public partial class BaseForm : MaterialForm {
        protected static string defaultMail = "user@email.com";
        public BaseForm() {
            InitializeComponent();
            DoubleBuffered = true;
            SetUpUi();
        }
        protected void SetUpUi()
        {
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private string GetDebuggerDisplay() => ToString();
    }
}
