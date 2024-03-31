using AccommodationManagerApp.Forms.Bill;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms
{
    public partial class ClientForm
    {
        private void addReq(object sender, System.EventArgs e)
        {
            AddReq addReq= new AddReq();
            addReq.ShowDialog();
            resetReq();

        }
        private void readReq()
        {
            int userId = user.Id;
            requests = _requestService.GetAllByUserId(userId);
            lstViewReq.Items.Clear();
            foreach (var request in requests)
            {
                var item = new ListViewItem(request.Id.ToString());
                item.SubItems.Add(request.Des);
                item.SubItems.Add(request.CreatedAtFormatted);
                item.SubItems.Add(request.Status.ToString());
                lstViewReq.Items.Add(item);
            }
        }
        private void deleteReq(object sender, System.EventArgs e)
        {
            if ( reqId != 0)
            {
                var confirmation = new ConfirmationForm("Xác nhận xóa yêu cầu?");
                var result = confirmation.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    _requestService.Delete(reqId);
                    resetReq();
                }
            }
            else
            {
                new ToastForm("Mời bạn chọn yêu cầu thì mới xóa được !", true).Show();
                return;
            }
        }
        private void updateReq(object sender, System.EventArgs e)
        {
            if (reqId != 0)
            {
                UpdateReq updateReq = new UpdateReq(reqId);
                updateReq.ShowDialog();
                resetReq();
            }
            else
            {
                new ToastForm("Mời bạn chọn yêu cầu !", true).Show();
                return;
            }
        }
    }
}
