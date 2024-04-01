using AccommodationManagerApp.Model;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms
{
    public partial class ClientForm
    {
        private int reqId;
        private void ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.Item.Selected)
            {
                reqId = int.Parse(e.Item.SubItems[0].Text);
                return;
            }
            reqId = 0;
        }
        private void resetReq()
        {
            reqId = 0;
            readReq();
        }
        private void deleteReq(object sender, System.EventArgs e)
        {
            if (reqId != 0)
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
                Request request = _requestService.GetById(reqId);
                RequestForm requestForm = new RequestForm(request);
                requestForm.ShowDialog();
                resetReq();
            }
            else
            {
                new ToastForm("Mời bạn chọn yêu cầu !", true).Show();
                return;
            }
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
        private void addReq(object sender, System.EventArgs e)
        {
            RequestForm requestForm = new RequestForm(null);
            requestForm.ShowDialog();
            resetReq();
        }
    }
}
