using AccommodationManagerApp.Model;
using System.Windows.Forms;
using AccommodationManagerApp.Util;
using System.Collections.Generic;

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
            InsertRequestIntoListView(_Requests);
        }

        private void InsertRequestIntoListView(List<Request> requests)
        {
            lstViewReq.Items.Clear();
            foreach (var request in requests)
            {
                var item = new ListViewItem(request.Id.ToString());
                item.SubItems.Add(request.Des);
                item.SubItems.Add(request.CreatedAtFormatted);
                item.SubItems.Add(text: RequestStatusExtension.ToVietnamese(request.Status));
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
        private void ButtonResponse_Click(object sender, System.EventArgs e)
        {
            _request = SelectRequest();
            if (_request == null) return;
            if (_request.Status == RequestStatus.Unsolve)
            {
                new ToastForm("Yêu cầu của bạn chưa được phản hồi !", true).Show();
                return;
            }
            new PreviewResponseForm(_request).ShowDialog();
        }

        private void LstViewReq_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var _request = SelectRequest();
            if (_request == null)
            {
                new ToastForm("Hãy chọn hoá đơn cần thao tác!", true).Show();
                return;
            }
            labelReqUser.Text = _request.User.Name;
            labelReqContent.Text = _request.Des;
            labelReqDate.Text = _request.CreatedAtFormatted;
            labelReqState.Text = RequestStatusExtension.ToVietnamese(_request.Status);
        }
    }
}
