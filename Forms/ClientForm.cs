using AccommodationManagerApp.Model;
using AccommodationManagerApp.Service;
using System.Collections.Generic;
using System.Threading;
using BillModel = AccommodationManagerApp.Model.Bill;
using System.Windows.Forms;
using AccommodationManagerApp.Util;

namespace AccommodationManagerApp.Forms
{
    public partial class ClientForm : BaseForm
    {
        private BillService _billService;
        private RequestService _requestService;
        private AuthenticationService _authenticationService;
        private User _user;
        private List<Request> _requests;
        private List<BillModel> _bills;
        public ClientForm()
        {
            InitializeComponent();
            SetListViewGridEnable();
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
            labelWaterPrice.Text = FormatText.IntegerToVnd(_billService.GetWaterPrice().Price);
            labelElectricityPrice.Text = FormatText.IntegerToVnd(_billService.GetElectricityPrice().Price);
            labelInternetPrice.Text = FormatText.IntegerToVnd(_billService.GetInternetPrice().Price);
        }
        private void LoadService()
        {
            _authenticationService = ServiceLocator.ServiceProvider.GetService(typeof(AuthenticationService)) as AuthenticationService;
            _billService = ServiceLocator.ServiceProvider.GetService(typeof(BillService)) as BillService;
            _requestService = ServiceLocator.ServiceProvider.GetService(typeof(RequestService)) as RequestService;
        }

        private void LoadPersonalInformation()
        {
            lblEmail.Text = _authenticationService.IsAuthenticated() ? _authenticationService.CurrentUser.Email : DefaultMail;
        }
        private void ShowInfor(object sender, System.EventArgs e)
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

        private void Logout(object sender, System.EventArgs e)
        {
            var confirmation = new ConfirmationForm("Bạn có chắc chắn muốn thoát");
            var result = confirmation.ShowDialog();
            if (result == DialogResult.Yes)
            {
                _authenticationService.Logout();
                Dispose();
                
                var thread = new Thread(() => {
                    Application.Run(new NewLoginForm());
                }); 
                thread.SetApartmentState(ApartmentState.STA); 
                thread.Start(); 
            }
        }

        private void SetListViewGridEnable() {
            ListViewBill.GridLines = true;
            ListViewRequest.GridLines = true;
        }
    }
}
