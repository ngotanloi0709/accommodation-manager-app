using AccommodationManagerApp.Model;
using AccommodationManagerApp.Service;
using System.Collections.Generic;

namespace AccommodationManagerApp.Forms {
    public partial class MainForm : BaseForm {
        private readonly RoomService _roomService;
        private readonly BuildingService _buildingService;
        private List<Building> Buildings { get; set; }
        private List<Room> Rooms { get; set; }

        public MainForm() {
            _roomService = ServiceLocator.ServiceProvider.GetService(typeof(RoomService)) as RoomService;
            _buildingService = ServiceLocator.ServiceProvider.GetService(typeof(BuildingService)) as BuildingService;
            InitializeComponent();
            LoadData();

            ListViewBuilding.GridLines = true;
            ListViewRoom.GridLines = true;
        }

        private void LoadData() {
            LoadRoomData();
            LoadBuildingData();
        }

        private void exportPdfButton_Click(object sender, System.EventArgs e) {
            BillDetail billDetailForm = new BillDetail();
            billDetailForm.Show();
        }
    }
}