using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing.Drawing2D;
using System;
using System.Windows.Forms;
using AccommodationManagerApp.Model;

namespace AccommodationManagerApp.Forms
{
    public partial class ReqForm : MaterialForm
    {
        public ReqForm()
        {
            InitializeComponent();
            SetUpUi();
        }

        protected void SetUpUi()
        {
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green400, Primary.Green700, Primary.Green700,
                Accent.Amber700, TextShade.WHITE);


            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        protected void close(object sender, System.EventArgs e)
        {
            ConfirmationForm confirmationForm = new ConfirmationForm("Bạn có muốn thoát không ?");
            if (confirmationForm.ShowDialog() == DialogResult.Yes)
            {
                this.Close();
            }
        }
        protected Request setReq()
        {
            try
            {
                string des = txtReq.Text; 
                Request req = new Request(des, null);
                return req;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
