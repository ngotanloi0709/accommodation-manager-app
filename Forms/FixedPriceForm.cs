using System.Windows.Forms;
using AccommodationManagerApp.Service;
using MaterialSkin.Controls;

namespace AccommodationManagerApp.Forms {
    public partial class FixedPriceForm : BaseForm {
        private readonly BillService _billService;
        private int _waterPrice = 0;
        private int _electricityPrice = 0;
        private int _internetPrice = 0;

        public FixedPriceForm(int waterPrice, int electricityPrice, int internetPrice) {
            this._waterPrice = waterPrice;
            this._electricityPrice = electricityPrice;
            this._internetPrice = internetPrice;

            _billService = ServiceLocator.ServiceProvider.GetService(typeof(BillService)) as BillService;

            InitializeComponent();

            LoadFixedPriceData();
        }

        private void LoadFixedPriceData() {
            textBoxWaterPrice.Text = _waterPrice.ToString();
            textBoxElectricityPrice.Text = _electricityPrice.ToString();
            textBoxInternetPrice.Text = _internetPrice.ToString();
        }

        private void buttonSave_Click(object sender, System.EventArgs e) {
            if (!IsAllDataFilled()) {
                return;
            }

            if (!IsSafeToUpdate()) {
                return;
            }

            _billService.UpdateFixedPrice(int.Parse(textBoxWaterPrice.Text), int.Parse(textBoxElectricityPrice.Text),
                int.Parse(textBoxInternetPrice.Text));
            DialogResult = DialogResult.OK;
        }
        
        private bool IsAllDataFilled() {
            if (string.IsNullOrEmpty(textBoxWaterPrice.Text)) {
                new ToastForm("Vui lòng nhập thông tin đơn giá nước").Show();
                return false;
            }

            if (string.IsNullOrEmpty(textBoxElectricityPrice.Text)) {
                new ToastForm("Vui lòng nhập thông tin đơn giá điện").Show();
                return false;
            }

            if (string.IsNullOrEmpty(textBoxInternetPrice.Text)) {
                new ToastForm("Vui lòng nhập thông tin giá Internet").Show();
                return false;
            }

            return true;
        }

        private bool IsSafeToUpdate() {
            if (int.Parse(textBoxWaterPrice.Text) < 10000) {
                new ToastForm("Đơn giá nước phải lớn hơn 10000").Show();
                return false;
            }

            if (int.Parse(textBoxElectricityPrice.Text) < 7500) {
                new ToastForm("Đơn giá điện phải lớn hơn 7500").Show();
                return false;
            }

            if (int.Parse(textBoxInternetPrice.Text) < 50000) {
                new ToastForm("Giá Internet phải lớn hơn 50000").Show();
                return false;
            }

            return true;
        }

        private void textBoxWaterPrice_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void buttonMinusWater_Click(object sender, System.EventArgs e) {
            ChangeFixedPrice(-100, textBoxWaterPrice);
        }

        private void buttonPlusWater_Click(object sender, System.EventArgs e) {
            ChangeFixedPrice(100, textBoxWaterPrice);
        }

        private void buttonMinusElectricity_Click(object sender, System.EventArgs e) {
            ChangeFixedPrice(-100, textBoxElectricityPrice);
        }

        private void buttonPlusElectricity_Click(object sender, System.EventArgs e) {
            ChangeFixedPrice(100, textBoxElectricityPrice);
        }

        private void buttonMinusInternet_Click(object sender, System.EventArgs e) {
            ChangeFixedPrice(-10000, textBoxInternetPrice);
        }

        private void buttonPlusInternet_Click(object sender, System.EventArgs e) {
            ChangeFixedPrice(10000, textBoxInternetPrice);
        }

        private void ChangeFixedPrice(int amount, MaterialTextBox textBox) {
            if (string.IsNullOrEmpty(textBox.Text)) {
                textBox.Text = amount.ToString();
            }
            else {
                textBox.Text = (int.Parse(textBox.Text) + amount).ToString();
            }

            if (int.Parse(textBox.Text) < 0) {
                textBox.Text = "0";
            }
        }

        private void FixedPriceForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (DialogResult != DialogResult.OK) {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}