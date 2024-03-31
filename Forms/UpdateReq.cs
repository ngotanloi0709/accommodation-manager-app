using AccommodationManagerApp.Model;
using AccommodationManagerApp.Service;

namespace AccommodationManagerApp.Forms
{
    public partial class UpdateReq : ReqForm
    {
        private int id;
        private Request preReq, postReq;
        private readonly RequestService _requestService;
        public UpdateReq(int id)
        {
            InitializeComponent();
            _requestService = ServiceLocator.ServiceProvider.GetService(typeof(RequestService)) as RequestService;
            this.id = id;
            preReq= _requestService.GetById(id);
            loadData();
        }
        private void loadData()
        {
            lblReqDate.Text += preReq.CreatedAtFormatted;
            txtReq.Text = preReq.Des;
        }
        private void update(object sender, System.EventArgs e)
        {
            postReq = setReq();
            if (postReq != null)
            {
                _requestService.Update(id, postReq);
                new ToastForm("Cập nhật thành công!", false).Show();
                this.Close();
            }
            else
            {
                new ToastForm("Xin mời điền đầy đủ thông tin!").Show();
            }
        }
    }
}
