using AccommodationManagerApp.Model;
using AccommodationManagerApp.Service;
using System;
using System.Drawing.Drawing2D;

namespace AccommodationManagerApp.Forms
{
    public partial class AddReq : ReqForm
    {
        private readonly RequestService _requestService;
        public AddReq()
        {
            Text = "Tạo Yêu Cầu";
            lblReqDate.Text += DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            _requestService = ServiceLocator.ServiceProvider.GetService(typeof(RequestService)) as RequestService;
            InitializeComponent();
        }
        private void add(object sender, System.EventArgs e)
        {
            Request req = setReq();
            if (req != null)
            {
                _requestService.Add(req);
                new ToastForm("Thêm thành Công!", false).Show();
                Close();
            }
            new ToastForm("Xin bạn nhập đầy đủ thông tin!").Show();
        }
    }
}
