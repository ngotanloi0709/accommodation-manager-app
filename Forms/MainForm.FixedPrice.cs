using System.Windows.Forms;
using AccommodationManagerApp.Util;

namespace AccommodationManagerApp.Forms {
    public partial class MainForm {
        private void LoadFixedPriceData() {
            labelWaterPrice.Text = FormatText.IntegerToVnd(_billService.GetWaterPrice().Price);
            labelElectricityPrice.Text = FormatText.IntegerToVnd(_billService.GetElectricityPrice().Price);
            labelInternetPrice.Text = FormatText.IntegerToVnd(_billService.GetInternetPrice().Price);
        }

        private void buttonEditFixedPrice_Click(object sender, System.EventArgs e) {
            FixedPriceForm fixedPriceForm = new FixedPriceForm();
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