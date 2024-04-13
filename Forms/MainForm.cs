using AccommodationManagerApp.Model;
using AccommodationManagerApp.Repository;
using AccommodationManagerApp.Service;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms {
    public partial class MainForm : BaseForm {
        private readonly RoomService _roomService;
        private readonly BuildingService _buildingService;
        private readonly BillService _billService;
        private readonly AuthenticationService _authenticationService;
        private readonly VehicleService _vehicleService;
        private readonly UserService _userService;
        private readonly ContractService _contractService;
        private readonly RequestService _requestService;
        private List<Bill> Bills { get; set; }
        private List<Building> Buildings { get; set; }
        private List<Room> Rooms { get; set; }
        private List<Vehicle> Vehicles { get; set; }
        private List<User> Users { get; set; }
        private List<User> SystemUsers { get; set; }
        private List<Contract> Contracts { get; set; }
        private List<Request> Requests { get; set; }

        private int _waterPrice;
        private int _electricityPrice;
        private int _internetPrice;

        public MainForm() {
            _roomService = ServiceLocator.ServiceProvider.GetService(typeof(RoomService)) as RoomService;
            _buildingService = ServiceLocator.ServiceProvider.GetService(typeof(BuildingService)) as BuildingService;
            _billService = ServiceLocator.ServiceProvider.GetService(typeof(BillService)) as BillService;
            _vehicleService = ServiceLocator.ServiceProvider.GetService(typeof(VehicleService)) as VehicleService;
            _authenticationService =
                ServiceLocator.ServiceProvider.GetService(typeof(AuthenticationService)) as AuthenticationService;
            _userService = ServiceLocator.ServiceProvider.GetService(typeof(UserService)) as UserService;
            _contractService = ServiceLocator.ServiceProvider.GetService(typeof(ContractService)) as ContractService;
            _requestService = ServiceLocator.ServiceProvider.GetService(typeof(RequestService)) as RequestService;

            InitializeComponent();
            LoadData();
            SetListViewGridEnable();
            Authorizing();
        }

        private void LoadData() {
            LoadPersonalInformation();
            LoadRoomData();
            LoadBuildingData();
            LoadBillData();
            LoadVehicleData();
            LoadUserData();
            LoadContractData();
            LoadFixedPriceData();
            LoadRequestData();
            LoadSystemUserData();
        }

        private void SetListViewGridEnable() {
            ListViewBuilding.GridLines = true;
            ListViewRoom.GridLines = true;
            ListViewVehicle.GridLines = true;
            ListViewUser.GridLines = true;
            ListViewUserRentList.GridLines = true;
            ListViewBill.GridLines = true;
            ListViewContract.GridLines = true;
            ListViewRoomUserList.GridLines = true;
            ListViewSystemUser.GridLines = true;
            ListViewRequest.GridLines = true;
        }

        private void buttonCurrentUserInformationManagement_Click(object sender, EventArgs e) {
            if (_authenticationService.IsAuthenticated()) {
                var userManagementForm =
                    new CurrentUserInformationForm(_authenticationService.CurrentUser);
                userManagementForm.ShowDialog();
                LoadPersonalInformation();
            }
            else {
                new ToastForm("Vui lòng đăng nhập để sử dụng chức năng này", true).Show();
            }
        }

        private void LoadPersonalInformation() {
            labelCurrentUserEmail.Text = _authenticationService.IsAuthenticated()
                ? _authenticationService.CurrentUser.Email
                : defaultMail;
        }

        private void Logout(object sender, EventArgs e) {
            var confirmation = new ConfirmationForm("Bạn có chắc chắn muốn thoát");
            var result = confirmation.ShowDialog();
            if (result == DialogResult.Yes) {
                _authenticationService.Logout();
                Dispose();

                var thread = new Thread(() => { Application.Run(new LoginForm()); });
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }

        private void materialButton5_Click(object sender, EventArgs e) {
            BuildingStatisticForm buildingStatisticForm = new BuildingStatisticForm();
            buildingStatisticForm.ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void Authorizing() {
            if (_authenticationService.CurrentUser.Role == UserRole.Manager) {
                DisableTabPage("tabPageHome");
                DisableTabPage("tabPageBuilding");
                DisableTabPage("tabPageRoom");
                DisableTabPage("tabPageTenants");
                DisableTabPage("tabPageVehicle");
                DisableTabPage("tabPageContract");
                DisableTabPage("tabPageSystemUser");
                DisableTabPage("tabPageRequest");
            }
        }

        private void DisableTabPage(string tabPageName) {
            var tabPage = TagControlMainForm.TabPages[tabPageName];
            if (tabPage != null) {
                TagControlMainForm.TabPages.Remove(tabPage);
            }
        }
    }
}