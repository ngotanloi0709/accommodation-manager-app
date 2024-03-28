using AccommodationManagerApp.Model;
using AccommodationManagerApp.Service;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms
{
    public partial class ContractForm : BaseForm
    {
        private Contract _contract;
        private readonly ContractService _contractService;
        private readonly UserService _userService;
        private List<Room> _rooms;
        private List<User> _users;
        private RoomService _roomService;

        public ContractForm(Contract contract)
        {
            _contractService = ServiceLocator.ServiceProvider.GetService(typeof(ContractService)) as ContractService;
            _userService = ServiceLocator.ServiceProvider.GetService(typeof(UserService)) as UserService;
            _roomService = ServiceLocator.ServiceProvider.GetService(typeof(RoomService)) as RoomService;
            _contract = contract;
            _rooms = _contractService.GetAvailableRooms();
            _users = _userService.GetAll();

            InitializeComponent();

            if (_contract != null)
            {
                // SetUpData(_contract);
            }

            SetUpComboBox();
        }

        private void SetUpComboBox()
        {
            comboBoxRoom.Items.Add("None");
            comboBoxTenant.Items.Add("None");
            comboBoxPrice.Items.Add("None");
            comboBoxEndDate.Items.Add("None");

            comboBoxRoom.SelectedIndex = 0;
            comboBoxTenant.SelectedIndex = 0;
            comboBoxPrice.SelectedIndex = 0;
            comboBoxEndDate.SelectedIndex = 0;

            if (_contract == null)
            {
                SetUpComboBoxRoom();
                SetUpComboBoxTenant();
            }

            SetUpComboBoxPrice();
            SetUpComboBoxEndDate();
        }

        private void SetUpComboBoxRoom()
        {
            foreach (var room in _rooms)
            {
                comboBoxRoom.Items.Add(room.RoomNumber);
            }
        }

        private void SetUpComboBoxTenant()
        {
            foreach (var user in _users)
            {
                comboBoxTenant.Items.Add(user.Name);
            }
        }

        private void SetUpComboBoxPrice()
        {
            comboBoxPrice.Items.Add("1.000.000");
            comboBoxPrice.Items.Add("1.500.000");
            comboBoxPrice.Items.Add("3.000.000");
            comboBoxPrice.Items.Add("5.000.000");
            comboBoxPrice.Items.Add("7.000.000");
            comboBoxPrice.Items.Add("10.000.000");
            comboBoxPrice.Items.Add("15.000.000");
            comboBoxPrice.Items.Add("20.000.000");
        }

        private void SetUpComboBoxEndDate()
        {
            comboBoxEndDate.Items.Add("1 tháng");
            comboBoxEndDate.Items.Add("3 tháng");
            comboBoxEndDate.Items.Add("6 tháng");
            comboBoxEndDate.Items.Add("12 tháng");
            comboBoxEndDate.Items.Add("18 tháng");
            comboBoxEndDate.Items.Add("24 tháng");
            comboBoxEndDate.Items.Add("36 tháng");
        }

        private void ButtonSave_Click(object sender, System.EventArgs e)
        {
            int? roomId = _roomService.GetIdByRoomNumber(comboBoxRoom.Text);
            int? userId = _userService.GetIdByName(comboBoxTenant.Text);

            if (IsAllDataFilled() && _contractService.IsRoomAvailableWithToast(roomId))
            {
                if (_contract == null)
                {
                    _contractService.Add(new Contract
                    {
                        RoomId = roomId,
                        UserId = userId,
                        Price = int.Parse(textBoxPrice.Text),
                        StartDate = dateTimePickerStartDate.Value,
                        EndDate = DateTime.ParseExact(textBoxEndDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture)
                    });
                }
                else
                {
                    _contract.RoomId = roomId;
                    _contract.UserId = userId;
                    _contract.Price = int.Parse(textBoxPrice.Text);
                    _contract.StartDate = dateTimePickerStartDate.Value;
                    _contract.EndDate =
                        DateTime.ParseExact(textBoxEndDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    _contractService.Update(_contract);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool IsAllDataFilled()
        {
            if (comboBoxTenant.SelectedIndex == 0)
            {
                new ToastForm("Vui lòng chọn người thuê", true).Show();
                return false;
            }

            if (comboBoxRoom.SelectedIndex == 0)
            {
                new ToastForm("Vui lòng chọn phòng", true).Show();
                return false;
            }

            if (string.IsNullOrEmpty(textBoxPrice.Text))
            {
                new ToastForm("Vui lòng nhập giá phòng", true).Show();
                return false;
            }

            if (comboBoxEndDate.SelectedIndex == 0)
            {
                new ToastForm("Vui lòng chọn thời hạn", true).Show();
                return false;
            }

            return true;
        }

        private void comboBoxPrice_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (comboBoxPrice.Text.Equals("None"))
            {
                textBoxPrice.Text = "";
                return;
            }

            textBoxPrice.Text = comboBoxPrice.Text.Replace(".", "");
        }

        private void comboBoxEndDate_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (comboBoxEndDate.Text.Equals("None"))
            {
                textBoxPrice.Text = "";
                return;
            }

            int months = int.Parse(comboBoxEndDate.Text.Split(' ')[0]);

            DateTime endDate = dateTimePickerStartDate.Value.AddMonths(months);

            textBoxEndDate.Text = endDate.ToString("dd/MM/yyyy");
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            textBoxPrice.Text = string.IsNullOrEmpty(textBoxPrice.Text)
                ? "500000"
                : (int.Parse(textBoxPrice.Text) + 500000).ToString();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            textBoxPrice.Text = string.IsNullOrEmpty(textBoxPrice.Text)
                ? "500000"
                : (int.Parse(textBoxPrice.Text) - 500000).ToString();
        }

        private void textBox_NumberInput(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ContractForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}