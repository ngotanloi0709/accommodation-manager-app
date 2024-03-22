using AccommodationManagerApp.Model;
using AccommodationManagerApp.Service;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms {
    public partial class MainForm : BaseForm {
        private readonly RoomService _roomService;
        private readonly BuildingService _buildingService;
        private readonly BillService _billService;
        private readonly AuthenticationService _authenticationService;
        private List<Bill> Bills { get; set; }
        private List<Building> Buildings { get; set; }
        private List<Room> Rooms { get; set; }

        public MainForm() {
            _roomService = ServiceLocator.ServiceProvider.GetService(typeof(RoomService)) as RoomService;
            _buildingService = ServiceLocator.ServiceProvider.GetService(typeof(BuildingService)) as BuildingService;
            _billService = ServiceLocator.ServiceProvider.GetService(typeof(BillService)) as BillService;
            _authenticationService = ServiceLocator.ServiceProvider.GetService(typeof(AuthenticationService)) as AuthenticationService;
            InitializeComponent();
            LoadData();

            ListViewBuilding.GridLines = true;
            ListViewRoom.GridLines = true;
            lstViewBill.GridLines = true;
        }

        private void LoadData() {
            LoadRoomData();
            LoadBuildingData();
            LoadBillData();
        }

        private void BtnLogOut_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _authenticationService.Logout();
                this.Close(); // Close the MainForm

                // Create a new thread for the LoginForm
                Thread loginFormThread = new Thread(() =>
                {
                    Application.SetCompatibleTextRenderingDefault(false);
                    LoginForm loginForm = new LoginForm();
                    Application.Run(loginForm);
                });

                // Start the new thread
                loginFormThread.SetApartmentState(ApartmentState.STA);
                loginFormThread.Start();
            }
        }
    }
}