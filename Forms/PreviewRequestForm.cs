using AccommodationManagerApp.Model;
using AccommodationManagerApp.Service;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms
{
    public partial class PreviewRequestForm : BaseForm
    {
        private readonly Request _request;
        private readonly UserService _userService;
        public PreviewRequestForm(Request request)
        {
            _userService = ServiceLocator.ServiceProvider.GetService(typeof(UserService)) as UserService;
            _request = request;
            InitializeComponent();
            SetUpRequestForm();
        }

        private void SetUpRequestForm()
        {
            labelRequestUser.Text = _userService.GetById(_request.UserId).Name.ToString();
            labelRequestDate.Text = _request.CreatedAt.ToString("dd/MM/yyyy");
            textBoxDesRequest.Text = _request.Des;
        }

        private void buttonResponse_Click(object sender, System.EventArgs e)
        {
            if(_request.Status == RequestStatus.Solved)
            {
                new ToastForm("Vấn đề đã được xử lý").Show();
                return;
            }
            var responseForm = new ResponseForm(_request);
            responseForm.ShowDialog();
            var result = responseForm.DialogResult;
            if (result == DialogResult.Yes) Close();
        }
    }
}
