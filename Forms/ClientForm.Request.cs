using AccommodationManagerApp.Model;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms
{
    public partial class ClientForm
    {
        private Request _request;
        private void DeleteReq(object sender, System.EventArgs e)
        {
            _request = SelectRequest();
            if (_request == null) return;

            var confirmation = new ConfirmationForm("Xác nhận xóa yêu cầu?");
            confirmation.ShowDialog();
            if (confirmation.DialogResult == DialogResult.Yes)
            {
                _requestService.Delete(_request.Id);
                LoadRequestData();
            }
        }
        private void UpdateReq(object sender, System.EventArgs e)
        {
            _request = SelectRequest();
            if (_request == null) return;
                
            InsertRequest(_request);
            
        }
        private void AddReq(object sender, System.EventArgs e)
        {
            InsertRequest(null);
        }
        private void InsertRequest(Request request)
        {
            var requestForm = new RequestForm(request);
            requestForm.ShowDialog();
            LoadRequestData();
        }
        private void LoadRequestData()
        {
            _Requests = _requestService.GetAllByUserId(_user.Id);
            lstViewReq.Items.Clear();
            foreach (var request in _Requests)
            {
                var item = new ListViewItem(request.Id.ToString());
                item.SubItems.Add(request.Des);
                item.SubItems.Add(request.CreatedAtFormatted);
                item.SubItems.Add(request.Status.ToString());
                lstViewReq.Items.Add(item);
            }
        }
        private Request SelectRequest()
        {
            if (lstViewReq.SelectedItems.Count > 0)
            {
                var index = lstViewReq.SelectedItems[0].Index;
                if (index < _Requests.Count) return _Requests[index];
            }
            new ToastForm("Mời bạn chọn yêu cầu !", true).Show();
            return null;
        }
    }
}
