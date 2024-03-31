using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using BillModel = AccommodationManagerApp.Model.Bill;

namespace AccommodationManagerApp.Forms.Bill
{
    public partial class BillForm : MaterialForm
    {
        public BillForm()
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

        protected void btnClose_Click(object sender, System.EventArgs e)
        {
            ConfirmationForm confirmationForm = new ConfirmationForm("Bạn có muốn thoát không ?");
            if (confirmationForm.ShowDialog() == DialogResult.Yes)
            {
                this.Close();
            }
        }

        protected BillModel setBill()
        {
            try
            {
                Double rent = Double.Parse(cmbboxRent.SelectedItem.ToString());
                Double water = Double.Parse(txtbxWater.Text);
                Double electric = Double.Parse(txtbxElectric.Text);
                BillModel bill = new BillModel(rent, electric, water, null);
                return bill;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void txtbxWater_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
