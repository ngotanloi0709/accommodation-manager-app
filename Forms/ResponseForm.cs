using AccommodationManagerApp.Model;
using AccommodationManagerApp.Service;
using System;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms
{
    public partial class ResponseForm : BaseForm
    {
        private readonly Request _request;
        private readonly RequestService _requestService;
        private readonly ResponseService _responseService;
        private readonly UserService _userService;
        private readonly AuthenticationService _authenticationService;

        public ResponseForm(Request request)
        {
            InitializeComponent();
            
            _request = request;
            _requestService = ServiceLocator.ServiceProvider.GetService(typeof(RequestService)) as RequestService;
            _responseService = ServiceLocator.ServiceProvider.GetService(typeof(ResponseService)) as ResponseService;
            _authenticationService = ServiceLocator.ServiceProvider.GetService(typeof(AuthenticationService)) as AuthenticationService;
            _userService = ServiceLocator.ServiceProvider.GetService(typeof(UserService)) as UserService;
            
            SetUpResponseForm();
        }
        private void SetUpResponseForm()
        {
            labelResponseUser.Text = _authenticationService.CurrentUser.Name;
            labelResponseDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private bool IsInputAllFilled()
        {
            if (!string.IsNullOrEmpty(textBoxDesResponse.Text)) return true;
            new ToastForm("Mời nhập phản hồi!", true).Show();
            return false;
        }

        private void buttonResponse_Click(object sender, EventArgs e)
        {
            if (!InsertResponse()) return;
            new ToastForm("Phản hồi thành công").Show();
            DialogResult = DialogResult.Yes;
            Close();
        }
        private bool InsertResponse()
        {
            if (!IsInputAllFilled()) return false;
            _responseService.Add(new Response(textBoxDesResponse.Text, _request.Id));
            _request.Status = RequestStatus.Solved;
            _requestService.Update(_request.Id, _request);
            return true;
        }
        private void SendResponseByEmail()
        {
            try
            {
                User user = _userService.GetById(_request.UserId);
                string subject = "Thư phản hồi từ chủ hộ";
                string body = "<html><body>";
                body += "<h2>Kính gửi " + user.Name + ",</h2>";
                body +=
                    "<p>Tôi rất lấy làm tiếc về những vấn đề mà bạn đã gặp phải, tôi xin phép được trình bày giải pháp từ phía bên tôi</p>";
                body += "<ul>";
                body += "<li>" + textBoxDesResponse.Text + "</li>";
                body += "</ul>";
                body += "<p>Mong bạn hài lòng với giải pháp này!</p>";
                body += "<p>Chân thành cảm ơn,</p>";
                body += "<p>Chủ hộ</p>";
                body += "</body></html>";

                string senderEmail = "www.khuanhuan1964@gmail.com";
                string senderPassword = "udkx wfia bvkb qoqw";
                string recipientEmail = "ql7769663@gmail.com";

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);

                MailMessage mailMessage = new MailMessage(senderEmail, recipientEmail, subject, body);
                mailMessage.IsBodyHtml = true;
                smtpClient.Send(mailMessage);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void buttonResponseEmail_Click(object sender, EventArgs e)
        {
            if (!InsertResponse()) return;

            SendResponseByEmail();

            new ToastForm("Phản hồi qua email thành công").Show();
            DialogResult = DialogResult.Yes;
            Close();
        }
    }
}
