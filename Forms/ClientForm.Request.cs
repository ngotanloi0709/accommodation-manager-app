using AccommodationManagerApp.Model;
using System.Windows.Forms;
using AccommodationManagerApp.Util;
using System.Collections.Generic;
using System;

namespace AccommodationManagerApp.Forms
{
    public partial class ClientForm
    {
        private Request _request;
        private void DeleteReq(object sender, EventArgs e)
        {
            _request = SelectRequest();
            
            if (_request == null) {
                new ToastForm("Mời bạn chọn yêu cầu cần xoá!", true).Show();
                return;
            }
            
            if (_request.Status == RequestStatus.Solved)
            {
                new ToastForm("Đã cập nhật trạng thái giải quyết không thể xoá !", true).Show();
                return;
            }

            var confirmation = new ConfirmationForm("Xác nhận xóa yêu cầu?");
            confirmation.ShowDialog();
            if (confirmation.DialogResult == DialogResult.Yes)
            {
                _requestService.Delete(_request.Id);
                LoadRequestData();
            }
        }
        private void UpdateReq(object sender, EventArgs e)
        {
            _request = SelectRequest();
            
            if (_request == null) {
                new ToastForm("Mời bạn chọn yêu cầu cần chỉnh sửa!", true).Show();
                return;
            }
            
            if (_request.Status == RequestStatus.Solved)
            {
                new ToastForm("Đã cập nhật trạng thái giải quyết không thể thay đổi !", true).Show();
                return;
            }
            
            InsertRequest(_request);
        }
        private void AddReq(object sender, EventArgs e)
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
            _requests = _requestService.GetAllByUserId(_user.Id);
            InsertRequestIntoListView(_requests);
        }

        private void InsertRequestIntoListView(List<Request> requests)
        {
            ListViewRequest.Items.Clear();
            foreach (var request in requests)
            {
                var item = new ListViewItem(request.Id.ToString());
                item.SubItems.Add(request.Des);
                item.SubItems.Add(request.CreatedAtFormatted);
                item.SubItems.Add(text: RequestStatusExtension.ToVietnamese(request.Status));
                ListViewRequest.Items.Add(item);
            }
        }
        private Request SelectRequest()
        {
            if (ListViewRequest.SelectedItems.Count > 0)
            {
                var index = ListViewRequest.SelectedItems[0].Index;
                if (index < _requests.Count) return _requests[index];
            }
            return null;
        }

        private void LstViewReq_SelectedIndexChanged(object sender, EventArgs e)
        {
            var request = SelectRequest();
            
            if(request == null) return;
            
            labelReqUser.Text = request.User.Name;
            labelReqContent.Text = request.Des;
            labelReqDate.Text = request.CreatedAtFormatted;
            labelReqState.Text = RequestStatusExtension.ToVietnamese(request.Status);
        }

        // Query System
        private void ButtonReqSearch_Click(object sender, EventArgs e)
        {
            List<object> time = QueryUtils.ChangeTextToDate(comboBoxReqTime.SelectedItem.ToString());
            RequestStatus status = RequestStatusExtension.ToRequestStatus(comboBoxReqState.SelectedItem.ToString());
            List<string> text = new List<string>() { null, null};
            _requests = _requestService.GetByCustomizeQuery(time, status, text);
            InsertRequestIntoListView(_requests);
        }
    }
}
