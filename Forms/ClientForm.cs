﻿using AccommodationManagerApp.Model;
using AccommodationManagerApp.Repository;
using AccommodationManagerApp.Service;
using System.Collections.Generic;
using System.Threading;
using BillModel = AccommodationManagerApp.Model.Bill;
using System.Windows.Forms;
namespace AccommodationManagerApp.Forms
{
    public partial class ClientForm : BaseForm
    {
        private BillService _billService;
        private AuthenticationService _authenticationService;
        private RequestService _requestService;
        
        private User _user;
        private List<Request> _Requests;
        private List<BillModel> _Bills;
        public ClientForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            LoadService();
            LoadEntity();
            LoadBillData();
            LoadRequestData();
            LoadPersonalInformation();
        }

        private void LoadEntity() 
        {
            _user = _authenticationService.CurrentUser;
        }
        private void LoadService()
        {
            _authenticationService = ServiceLocator.ServiceProvider.GetService(typeof(AuthenticationService)) as AuthenticationService;
            _billService = ServiceLocator.ServiceProvider.GetService(typeof(BillService)) as BillService;
            _requestService = ServiceLocator.ServiceProvider.GetService(typeof(RequestService)) as RequestService;
        }

        private void LoadPersonalInformation()
        {
            if (_authenticationService.IsAuthenticated())
            {
                lblEmail.Text = _authenticationService.CurrentUser.Email;
            } else
            {
                lblEmail.Text = defaultMail;
                btnLogin.Visible = true;
            }
        }
        private void showInfor(object sender, System.EventArgs e)
        {
            if (_authenticationService.IsAuthenticated())
            {
                var userManagementForm = new CurrentUserInformationForm(_authenticationService.CurrentUser);
                userManagementForm.ShowDialog();
            }
            else
            {
                new ToastForm("Vui lòng đăng nhập để sử dụng chức năng này", true).Show();
            }
        }

        private void login(object sender, System.EventArgs e)
        {
            var confirmation = new ConfirmationForm("Xác nhận đăng nhập");
            var result = confirmation.ShowDialog();
            if (result == DialogResult.Yes)
            {
                _authenticationService.Logout();
                Close();

                var loginFormThread = new Thread(() =>
                {
                    Application.SetCompatibleTextRenderingDefault(false);
                    var loginForm = new LoginForm();
                    Application.Run(loginForm);
                });

                loginFormThread.SetApartmentState(ApartmentState.STA);
                loginFormThread.Start();
            }
        }

        private void logout(object sender, System.EventArgs e)
        {
            var confirmation = new ConfirmationForm("Bạn có chắc chắn muốn thoát");
            var result = confirmation.ShowDialog();
            if (result == DialogResult.Yes)
            {
                _authenticationService.Logout();
                LoadPersonalInformation();
            }
        }
    }
}
