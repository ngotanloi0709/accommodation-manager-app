using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using AccommodationManagerApp.Service;
using BillModel = AccommodationManagerApp.Model.Bill;
using System;

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
            ConfirmationForm confirmationForm = new ConfirmationForm("Do you want to close ?");
            if (confirmationForm.ShowDialog() == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void clearTxt(object sender, System.EventArgs e)
        {
            if (sender is MaterialTextBox textBox)
            {
                if (textBox.Text == "Water Price" || textBox.Text == "Electric Price")
                {
                    textBox.Text = "";
                }
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
            } catch(Exception)
            {
                return null;
            }
        }
    }
}
