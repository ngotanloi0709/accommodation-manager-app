using AccommodationManagerApp.Model;
using System.Windows.Forms;
using AccommodationManagerApp.Util;
using System;

namespace AccommodationManagerApp.Forms
{
    public partial class MainForm
    {
        private Request _request;

        private void LoadRequestData()
        {
            _Requests = _requestService.GetAll();
            lstViewReq.Items.Clear();
            foreach (var request in _Requests)
            {
                var item = new ListViewItem(request.Id.ToString());
                item.SubItems.Add(request.Des);
                item.SubItems.Add(request.CreatedAtFormatted);
                item.SubItems.Add( RequestStatusExtension.ToVietnamese(request.Status));
                lstViewReq.Items.Add(item);
            }
        }
        private void buttonResponse_Click(object sender, EventArgs e)
        {
            _request = SelectRequest();
            var responseForm = new ResponseForm(_request);
            responseForm.ShowDialog();
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