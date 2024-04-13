using System.Windows.Forms;
using AccommodationManagerApp.Util;

namespace AccommodationManagerApp.Forms {
    public partial class MainForm {
        private void LoadFixedPriceData() {
            _waterPrice = _billService.GetWaterPrice().Price;
            _electricityPrice = _billService.GetElectricityPrice().Price;
            _internetPrice = _billService.GetInternetPrice().Price;
            
            labelWaterPrice.Text = FormatText.IntegerToVnd(_waterPrice);
            labelElectricityPrice.Text = FormatText.IntegerToVnd(_electricityPrice);
            labelInternetPrice.Text = FormatText.IntegerToVnd(_internetPrice);
        }

        private void buttonEditFixedPrice_Click(object sender, System.EventArgs e) {
            var fixedPriceForm = new FixedPriceForm(_waterPrice, _electricityPrice, _internetPrice);
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