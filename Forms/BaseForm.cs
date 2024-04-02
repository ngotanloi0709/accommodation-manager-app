﻿using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
namespace AccommodationManagerApp.Forms {
    public partial class BaseForm : MaterialForm {
        protected static string defaultMail = "user@email.com";
        public BaseForm() {
            InitializeComponent();
            SetUpUi();
        }
        protected void SetUpUi()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green400, Primary.Green700, Primary.Green700,
                Accent.Amber700, TextShade.WHITE);

            
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        protected void exit(object sender, System.EventArgs e)
        {
            var confirmation = new ConfirmationForm("Bạn có chắc chắn muốn thoát");
            var result = confirmation.ShowDialog();
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
