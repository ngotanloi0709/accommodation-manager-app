using System;
using System.Windows.Forms;
using AccommodationManagerApp.Service;

namespace AccommodationManagerApp.Forms
{
    public partial class LoginForm : BaseForm
    {
        private readonly AuthenticationService _authenticationService;
        public LoginForm()
        {
            _authenticationService = ServiceLocator.ServiceProvider.GetService(typeof(AuthenticationService)) as AuthenticationService;
            InitializeComponent();
            btnExit.Visible = false;
        }
    }
}

