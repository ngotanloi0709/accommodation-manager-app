﻿using AccommodationManagerApp.Model;
using AccommodationManagerApp.Service;
using System;
using System.Collections.Generic;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms {
    public partial class MainForm : BaseForm {
        private readonly RoomService _roomService;
        private readonly BuildingService _buildingService;
        private readonly AuthenticationService _authenticationService;
        private readonly VehicleService _vehicleService;
        private List<Building> Buildings { get; set; }
        private List<Room> Rooms { get; set; }

        private List<Vehicle> Vehicles { get; set; }
        public MainForm() {
            _roomService = ServiceLocator.ServiceProvider.GetService(typeof(RoomService)) as RoomService;
            _buildingService = ServiceLocator.ServiceProvider.GetService(typeof(BuildingService)) as BuildingService;
            _vehicleService = ServiceLocator.ServiceProvider.GetService(typeof(VehicleService)) as VehicleService;
            _authenticationService = ServiceLocator.ServiceProvider.GetService(typeof(AuthenticationService)) as AuthenticationService;
            InitializeComponent();
            LoadData();

            ListViewBuilding.GridLines = true;
            ListViewRoom.GridLines = true;
            ListViewVehicle.GridLines = true;
        }

        private void LoadData() {
            LoadRoomData();
            LoadBuildingData();
            LoadVehicleData();
        }

        private void exportPdfButton_Click(object sender, System.EventArgs e) {
            BillDetail billDetailForm = new BillDetail();
            billDetailForm.Show();
        }

        private void btnLogOut_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _authenticationService.Logout();
                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.ShowDialog();
                this.Close();
            }
        }
    }
}