using MaterialSkin;
using MaterialSkin.Controls;

namespace AccommodationManagerApp.Forms
{
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
            SetUpUi();
        }

        private void SetUpUi()
        {
            // Set the MaterialSkinManager to the form
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green400, Primary.Green700, Primary.Green700, Accent.Purple400, TextShade.WHITE);
        }
    }
}
