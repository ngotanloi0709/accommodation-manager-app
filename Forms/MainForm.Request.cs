using AccommodationManagerApp.Model;
using System.Windows.Forms;
using AccommodationManagerApp.Util;
using System;
using System.Collections.Generic;

namespace AccommodationManagerApp.Forms
{
    public partial class MainForm
    {
        private Request _request;

        private void LoadRequestData()
        {
            _Requests = _requestService.GetAllWithUser();
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
                item.SubItems.Add(RequestStatusExtension.ToVietnamese(request.Status));
                lstViewReq.Items.Add(item);
            }
        }
        private void ButtonResponse_Click(object sender, EventArgs e)
        {
            _request = SelectRequest();
            if (_request == null)
            {
                new ToastForm("Mời bạn chọn yêu cầu !", true).Show();
                return;
            }
            _request.Status = RequestStatus.Solved;
            _requestService.Update(_request.Id,_request);
            LoadRequestData();
        }
        private Request SelectRequest()
        {
            if (lstViewReq.SelectedItems.Count > 0)
            {
                var index = lstViewReq.SelectedItems[0].Index;
                if (index < _Requests.Count) return _Requests[index];
            }
            return null;
        }
        private void LstViewReq_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _request = SelectRequest();
            labelReqUser.Text = _request.User.Name;
            labelReqContent.Text = _request.Des;
            labelReqDate.Text = _request.CreatedAtFormatted;
            labelReqState.Text = RequestStatusExtension.ToVietnamese(_request.Status);
        }

        // Query System
        private void ButtonReqSearch_Click(object sender, EventArgs e)
        {
            List<object> time = QueryUtils.ChangeTextToDate(comboBoxReqTime.SelectedItem.ToString());
            RequestStatus status = RequestStatusExtension.ToRequestStatus(comboBoxReqState.SelectedItem.ToString());
            List<string> text = QueryUtils.ChangeSearchInput((string)comboBoxReqSearch.SelectedItem, textBoxReqSearch.Text);
            var queryRequests = _requestService.GetByCustomizeQuery(_Requests, time, status, text);
            InsertRequestIntoListView(queryRequests);
        }
    }
}