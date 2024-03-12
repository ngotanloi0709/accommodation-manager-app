using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace AccommodationManagerApp.Forms {
    public partial class BaseForm : MaterialForm {
        public BaseForm() {
            InitializeComponent();
            SetUpUi();
        }
        
        protected void SetUpUi()
        {
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green400, Primary.Green700, Primary.Green700,
                Accent.Purple400, TextShade.WHITE);
            
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}