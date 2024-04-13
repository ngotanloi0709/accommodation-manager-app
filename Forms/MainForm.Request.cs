using AccommodationManagerApp.Model;
using System.Windows.Forms;
using AccommodationManagerApp.Util;
using System;
using System.Collections.Generic;

namespace AccommodationManagerApp.Forms
{
    public partial class MainForm
    {
        private void LoadRequestData()
        {
            Requests = _requestService.GetAllWithUser();
            InsertRequestIntoListView(Requests);
        }

        private void InsertRequestIntoListView(List<Request> requests)
        {
            ListViewRequest.Items.Clear();
            foreach (var request in requests)
            {
                var item = new ListViewItem(request.Id.ToString());
                item.SubItems.Add(request.Des);
                item.SubItems.Add(request.CreatedAtFormatted);
                item.SubItems.Add(RequestStatusExtension.ToVietnamese(request.Status));
                ListViewRequest.Items.Add(item);
            }
        }
        private void ButtonResponse_Click(object sender, EventArgs e)
        {
            var request = SelectRequest();
            if (request == null)
            {
                new ToastForm("Mời bạn chọn yêu cầu!", true).Show();
                return;
            }
            request.Status = RequestStatus.Solved;
            _requestService.Update(request.Id, request);
            LoadRequestData();
        }
        private Request SelectRequest()
        {
            if (ListViewRequest.SelectedItems.Count > 0)
            {
                var index = ListViewRequest.SelectedItems[0].Index;
                if (index < Requests.Count) return Requests[index];
            }
            return null;
        }
        private void LstViewReq_SelectedIndexChanged(object sender, EventArgs e)
        {
            var request = SelectRequest();
            if (request == null) return;   
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
            List<string> text = QueryUtils.ChangeSearchInput((string)comboBoxReqSearch.SelectedItem, textBoxReqSearch.Text);
            Requests = _requestService.GetByCustomizeQuery(time, status, text);
            InsertRequestIntoListView(Requests);
        }
        
        private void ButtonReloadRequest_Click(object sender, EventArgs e)
        {
            LoadRequestData();
            new ToastForm("Đã tải lại dữ liệu yêu cầu").Show();
        }
    }
}