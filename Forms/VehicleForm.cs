using AccommodationManagerApp.Model;
using AccommodationManagerApp.Service;
using AccommodationManagerApp.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms
{
    public partial class VehicleForm : BaseForm
    {
        private readonly VehicleService _vehicleService;
        private readonly RoomService _roomService;
        private Vehicle _vehicle;
        private List<Room> _rooms;


        public VehicleForm(Vehicle vehicle)
        {
            _roomService = ServiceLocator.ServiceProvider.GetService(typeof(RoomService)) as RoomService;
            _vehicleService = ServiceLocator.ServiceProvider.GetService(typeof(VehicleService)) as VehicleService;
            _vehicle = vehicle;
            _rooms = _roomService.GetAll();

            InitializeComponent();
            SetUpComboBoxes();

            if (_vehicle != null)
            {
                SetUpData(_vehicle);
                Text = "Chỉnh sửa thông tin phương tiện";
            }
        }

        private void SetUpComboBoxes()
        {
            SetUpComboBoxRoom();
            SetUpComboBoxVehicleType();
            SetUpComboBoxVehiclePrice();

            comboBoxCategory.SelectedIndex = 0;
            comboBoxRoom.SelectedIndex = 0;
            comboBoxVehiclePrice.SelectedIndex = 0;
        }

        private void SetUpComboBoxRoom()
        {
            comboBoxRoom.Items.Add("None");

            foreach (var room in _rooms)
            {
                comboBoxRoom.Items.Add(room.RoomNumber);
            }
        }

        private void SetUpComboBoxVehicleType()
        {
            comboBoxCategory.Items.Add(VehicleCategory.TwoWheel.ToVietnamese());
            comboBoxCategory.Items.Add(VehicleCategory.FourWheel.ToVietnamese());
            comboBoxCategory.Items.Add(VehicleCategory.ThreeWheel.ToVietnamese());
            comboBoxCategory.Items.Add(VehicleCategory.Bicycle.ToVietnamese());
            comboBoxCategory.Items.Add(VehicleCategory.ElectricBicycle.ToVietnamese());
        }

        private void SetUpComboBoxVehiclePrice()
        {
            comboBoxVehiclePrice.Items.Add("None");
            comboBoxVehiclePrice.Items.Add("100.000");
            comboBoxVehiclePrice.Items.Add("200.000");
            comboBoxVehiclePrice.Items.Add("400.000");
            comboBoxVehiclePrice.Items.Add("600.000");
            comboBoxVehiclePrice.Items.Add("1.000.000");
        }

        private void SetUpData(Vehicle vehicle)
        {
            comboBoxCategory.SelectedItem = vehicle.Category.ToVietnamese();
            textBoxName.Text = vehicle.Name;
            textBoxPrice.Text = vehicle.Price.ToString();
            textBoxNumber.Text = vehicle.Number;
            comboBoxRoom.SelectedItem = vehicle.Room?.RoomNumber ?? "None";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (IsAllDataFilled())
            {

                string vehicleName = textBoxName.Text;
                VehicleCategory vehicleCategory = comboBoxCategory.SelectedItem.ToString().ToVehicleCategory();
                string vehicleNumber = textBoxNumber.Text;
                int? roomId = comboBoxRoom.Text.Equals("None") ? null : _roomService.GetIdByRoomNumber(comboBoxRoom.Text);
                int price = int.Parse(textBoxPrice.Text);
                if (_vehicle == null && _vehicleService.IsVehicleNumberExists(vehicleNumber))
                {
                    new ToastForm("Tên phương tiện đã tồn tại").Show();
                    return;
                }

                if (_vehicle == null)
                {
                    _vehicleService.Add(new Vehicle
                    {
                        Name = vehicleName,
                        Number = vehicleNumber,
                        RoomId = roomId,
                        Category = vehicleCategory,
                        Price = price
                    });
                }
                else
                {
                    _vehicle.Name = vehicleName;
                    _vehicle.Number = vehicleNumber;
                    _vehicle.RoomId = roomId;
                    _vehicle.Category = vehicleCategory;
                    _vehicle.Price = price;
                    _vehicleService.Update(_vehicle.Id, _vehicle);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool IsAllDataFilled()
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                new ToastForm("Vui lòng nhập tên/miêu tả cho phương tiện", true).Show();
                return false;
            }

            if (string.IsNullOrEmpty(textBoxNumber.Text))
            {
                new ToastForm("Vui lòng nhập biển số phương tiện", true).Show();
                return false;
            }

            if (!InputHelper.IsValidPrice(textBoxPrice.Text))
            {
                new ToastForm("Vui lòng nhập số tiền hợp lệ", true).Show();
                return false;
            }

            return true;
        }

        private void comboBoxVehiclePrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxVehiclePrice.Text.Equals("None"))
            {
                textBoxPrice.Text = "";
                return;
            }

            textBoxPrice.Text = comboBoxVehiclePrice.Text.Replace(".", "");
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            textBoxPrice.Text = string.IsNullOrEmpty(textBoxPrice.Text)
                ? "25000"
                : (int.Parse(textBoxPrice.Text) + 25000).ToString();

            if (int.Parse(textBoxPrice.Text) < 0)
            {
                textBoxPrice.Text = "0";
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            textBoxPrice.Text = string.IsNullOrEmpty(textBoxPrice.Text)
                ? "25000"
                : (int.Parse(textBoxPrice.Text) - 25000).ToString();

            if (int.Parse(textBoxPrice.Text) < 0)
            {
                textBoxPrice.Text = "0";
            }
        }

        private void VehicleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}