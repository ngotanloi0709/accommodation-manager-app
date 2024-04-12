using AccommodationManagerApp.Model;
using AccommodationManagerApp.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms
{
    public partial class ViewUserInformation : BaseForm
    {
        private readonly UserService _userService;
        private readonly VehicleService _vehicleService;
        private readonly RoomService _roomService;
        private readonly User _user;
        public ViewUserInformation(User user)
        {
            _userService = ServiceLocator.ServiceProvider.GetService(typeof(UserService)) as UserService;
            _vehicleService = ServiceLocator.ServiceProvider.GetService(typeof(VehicleService)) as VehicleService;
            _roomService = ServiceLocator.ServiceProvider.GetService(typeof(RoomService)) as RoomService;
            _user = user;
            InitializeComponent();
        }

        private void btnCheckVehicles_Click(object sender, EventArgs e)
        {
            ViewUserVehicleInfor viewUserVehicleInfor = new ViewUserVehicleInfor(_user);
            viewUserVehicleInfor.ShowDialog();
        }

        private void btnTransactionHistory_Click(object sender, EventArgs e)
        {
            ViewUserTransactionInfor viewUserTransactionInfor = new ViewUserTransactionInfor(_user);
            viewUserTransactionInfor.ShowDialog();

        }

        private void btnRoomInfor_Click(object sender, EventArgs e)
        {
            ViewUserRoomInfor viewUserRoomInfor = new ViewUserRoomInfor(_user);
            viewUserRoomInfor.ShowDialog();
        }

    }
}
