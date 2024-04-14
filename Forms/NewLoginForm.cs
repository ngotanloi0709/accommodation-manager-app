using System;
using System.Threading;
using System.Windows.Forms;
using AccommodationManagerApp.Service;
using AccommodationManagerApp.Util;

namespace AccommodationManagerApp.Forms {
    public partial class NewLoginForm : BaseForm {
        private readonly AuthenticationService _authenticationService;
        
        public NewLoginForm() {
            InitializeComponent();
            _authenticationService = ServiceLocator.ServiceProvider.GetService(typeof(AuthenticationService)) as AuthenticationService;
        }
        
        private void Login(object sender, EventArgs e)
        {
            var email = txtEmail1.Text;
            var password = txtPass1.Text;
            
            if (!InputHelper.IsValidInputEmail(email))
            {
                new ToastForm("Vui lòng nhập email hợp lệ", true).Show();
                return;
            }
            
            var result = _authenticationService.Authenticate(email, password);
            
            if (!result)
            {
                new ToastForm("Đăng Nhập Sai Thông Tin !!!", true).Show();
                return;
            }
            
            Dispose();
            
            var thread = new Thread(() => { Application.Run(new SplashForm()); });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}