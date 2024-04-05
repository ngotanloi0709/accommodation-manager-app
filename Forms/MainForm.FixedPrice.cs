using System.Windows.Forms;
using AccommodationManagerApp.Util;

namespace AccommodationManagerApp.Forms {
    public partial class MainForm {
        private void LoadFixedPriceData() {
            waterPrice = _billService.GetWaterPrice().Price;
            electricityPrice = _billService.GetElectricityPrice().Price;
            internetPrice = _billService.GetInternetPrice().Price;
            
            labelWaterPrice.Text = FormatText.IntegerToVnd(waterPrice);
            labelElectricityPrice.Text = FormatText.IntegerToVnd(electricityPrice);
            labelInternetPrice.Text = FormatText.IntegerToVnd(internetPrice);
        }

        private void buttonEditFixedPrice_Click(object sender, System.EventArgs e) {
            var fixedPriceForm = new FixedPriceForm(waterPrice, electricityPrice, internetPrice);
            fixedPriceForm.ShowDialog();
            
            if (fixedPriceForm.DialogResult == DialogResult.Cancel) {
                return;
            }
            
            if (fixedPriceForm.DialogResult == DialogResult.OK) {
                LoadFixedPriceData();
                new ToastForm("Cập nhật chi phí cố định thành công").Show();
            }
            else {
                new ToastForm("Cập nhật chi phí cố định thất bại").Show();
            }
        }
    }
}