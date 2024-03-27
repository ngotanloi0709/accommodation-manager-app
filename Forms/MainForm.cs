using AccommodationManagerApp.Model;
using AccommodationManagerApp.Service;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using BillModel = AccommodationManagerApp.Model.Bill;
using AccommodationManagerApp.Repository;

namespace AccommodationManagerApp.Forms
{
    public partial class MainForm : BaseForm
    {
        private readonly RoomService _roomService;
        private readonly BuildingService _buildingService;
        private readonly BillService _billService;
        private readonly VehicleService _vehicleService;
        private readonly AuthenticationService _authenticationService;
        private List<BillModel> Bills { get; set; }
        private readonly UserService _userService;
        private List<Building> Buildings { get; set; }
        private List<Room> Rooms { get; set; }

        private List<Vehicle> Vehicles { get; set; }
        private List<User> Users { get; set; }
        public MainForm()
        {
            _roomService = ServiceLocator.ServiceProvider.GetService(typeof(RoomService)) as RoomService;
            _buildingService = ServiceLocator.ServiceProvider.GetService(typeof(BuildingService)) as BuildingService;
            _billService = ServiceLocator.ServiceProvider.GetService(typeof(BillService)) as BillService;
            _vehicleService = ServiceLocator.ServiceProvider.GetService(typeof(VehicleService)) as VehicleService;
            _userService = ServiceLocator.ServiceProvider.GetService(typeof(UserService)) as UserService;
            _authenticationService = ServiceLocator.ServiceProvider.GetService(typeof(AuthenticationService)) as AuthenticationService;
            InitializeComponent();
            LoadData();

            ListViewBuilding.GridLines = true;
            ListViewRoom.GridLines = true;
            ListViewVehicle.GridLines = true;
            ListViewUser.GridLines = true;
            ListViewUserRentList.GridLines = true;
            lstViewBill.GridLines = true;
        }

        private void LoadData()
        {
            LoadPersonalInformation();
            LoadRoomData();
            LoadBuildingData();
            readBill();
            LoadVehicleData();
            LoadUserData();
        }

        private void buttonCurrentUserInformationManagement_Click(object sender, System.EventArgs e)
        {
            if (_authenticationService.IsAuthenticated())
            {
                CurrentUserInformationForm userManagementForm = new CurrentUserInformationForm(_authenticationService.CurrentUser);
                userManagementForm.ShowDialog();
                LoadPersonalInformation();
            } else {
                new ToastForm("Vui lòng đăng nhập để sử dụng chức năng này", true).Show();
            }
        }
        
        private void LoadPersonalInformation()
        {
            if (_authenticationService.IsAuthenticated())
            {
                labelCurrentUserEmail.Text = _authenticationService.CurrentUser.Email;
            } else
            {
                labelCurrentUserEmail.Text = defaultMail;
                btnLogin.Visible = true;
            }
        }
    }
}