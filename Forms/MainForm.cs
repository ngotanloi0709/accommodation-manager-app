using AccommodationManagerApp.Model;
using AccommodationManagerApp.Repository;
using AccommodationManagerApp.Service;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms
{
    public partial class MainForm : BaseForm
    {
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
        private List<Contract> Contracts { get; set; }
        private List<Request> _Requests;

        private int waterPrice = 0;
        private int electricityPrice = 0;
        private int internetPrice = 0;

        public MainForm()
        {
            _roomService = ServiceLocator.ServiceProvider.GetService(typeof(RoomService)) as RoomService;
            _buildingService = ServiceLocator.ServiceProvider.GetService(typeof(BuildingService)) as BuildingService;
            _billService = ServiceLocator.ServiceProvider.GetService(typeof(BillService)) as BillService;
            _vehicleService = ServiceLocator.ServiceProvider.GetService(typeof(VehicleService)) as VehicleService;
            _authenticationService = ServiceLocator.ServiceProvider.GetService(typeof(AuthenticationService)) as AuthenticationService;
            _userService = ServiceLocator.ServiceProvider.GetService(typeof(UserService)) as UserService;
            _contractService = ServiceLocator.ServiceProvider.GetService(typeof(ContractService)) as ContractService;
            _requestService = ServiceLocator.ServiceProvider.GetService(typeof(RequestService)) as RequestService;

            InitializeComponent();
            LoadData();
            SetListViewGridEnable();
        }

        private void LoadData()
        {
            LoadPersonalInformation();
            LoadRoomData();
            LoadBuildingData();
            LoadBillData();
            LoadVehicleData();
            LoadUserData();
            LoadContractData();
            LoadFixedPriceData();
            LoadRequestData();
        }
        private void SetListViewGridEnable()
        {
            ListViewBuilding.GridLines = true;
            ListViewRoom.GridLines = true;
            ListViewVehicle.GridLines = true;
            ListViewUser.GridLines = true;
            ListViewUserRentList.GridLines = true;
            ListViewBill.GridLines = true;
            ListViewContract.GridLines = true;
            ListViewRoomUserList.GridLines = true;
        }
        private void buttonCurrentUserInformationManagement_Click(object sender, EventArgs e)
        {
            if (_authenticationService.IsAuthenticated())
            {
                var userManagementForm =
                    new CurrentUserInformationForm(_authenticationService.CurrentUser);
                userManagementForm.ShowDialog();
                LoadPersonalInformation();
            }
            else
            {
                new ToastForm("Vui lòng đăng nhập để sử dụng chức năng này", true).Show();
            }
        }
        private void LoadPersonalInformation()
        {
            labelCurrentUserEmail.Text = _authenticationService.IsAuthenticated() ? _authenticationService.CurrentUser.Email : defaultMail;
        }
        private void Logout(object sender, EventArgs e)
        {
            var confirmation = new ConfirmationForm("Bạn có chắc chắn muốn thoát");
            var result = confirmation.ShowDialog();
            if (result == DialogResult.Yes)
            {
                _authenticationService.Logout();
                Close();
            }
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            BuildingStatisticForm buildingStatisticForm = new BuildingStatisticForm();
            buildingStatisticForm.ShowDialog();
        }
    }
}