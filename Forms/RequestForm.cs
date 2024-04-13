using AccommodationManagerApp.Model;
using AccommodationManagerApp.Service;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms {
    public partial class RequestForm : BaseForm {
        private Request _request;
        private readonly RequestService _requestService;
        private readonly AuthenticationService _authenticaitonService;


        public RequestForm(Request request) {
            InitializeComponent();

            _requestService = ServiceLocator.ServiceProvider.GetService(typeof(RequestService)) as RequestService;
            _authenticaitonService =
                ServiceLocator.ServiceProvider.GetService(typeof(AuthenticationService)) as AuthenticationService;
            _request = request;

            if (_request != null) SetUpData();
        }

        private void SetUpData() {
            Text = "Chỉnh sửa yêu cầu";
            txtReq.Text = _request.Des;
        }

        private bool IsAllTextBoxFilled() {
            var result = string.IsNullOrEmpty(txtReq.Text);
            if (result) {
                new ToastForm("Vui lòng điền đầy đủ thông tin.", true).Show();
            }

            if (txtReq.Text.Length > 100) {
                new ToastForm("Giới Hạn Văn Bản 100 ký tự !", true).Show();
                return true;
            }

            return result;
        }

        private void AddAndUpdateRequest(object sender, System.EventArgs e) {
            if (IsAllTextBoxFilled()) return;
            
            if (_request == null) {
                _request = new Request(txtReq.Text, _authenticaitonService.CurrentUser.Id);
                _requestService.Add(_request);
            }
            else {
                _request.Des = txtReq.Text;
                _request.UserId = _authenticaitonService.CurrentUser.Id;
                _requestService.Update(_request.Id, _request);
            }

            new ToastForm(_request != null ? "Cập nhật thành công" : "Tạo mới thành công").Show();

            Close();
        }

        private void Close(object sender, System.EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void RequestForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (DialogResult != DialogResult.OK) {
                DialogResult = DialogResult.Cancel;
            }            
        }
    }
}