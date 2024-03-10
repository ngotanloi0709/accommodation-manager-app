using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms
{
    public partial class SplashForm : MaterialForm
    {
        public SplashForm()
        {
            InitializeComponent();
            SetUpUi();
            timerProgress.Start();
        }
        private void SetUpUi()
        {
            Cursor = Cursors.Arrow;
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green400, Primary.Green700, Primary.Green700,
                Accent.LightBlue100, TextShade.WHITE);
        }
        int start = 0;
        private void timerProgress_Tick(object sender, EventArgs e)
        {
            start += 2;
            progressBar.Value = start;
            if (progressBar.Value == 100)
            {
                timerProgress.Stop();
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
        }
    }
}
