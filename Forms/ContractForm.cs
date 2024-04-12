using AccommodationManagerApp.Model;
using AccommodationManagerApp.Service;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using AccommodationManagerApp.Util;

namespace AccommodationManagerApp.Forms {
    public partial class ContractForm : BaseForm {
        private Contract _contract;
        private readonly ContractService _contractService;
        private readonly UserService _userService;
        private List<Room> _rooms;
        private List<User> _users;
        private RoomService _roomService;
        private BillService _billService;

        public ContractForm(Contract contract) {
            InitializeComponent();
            
            _contractService = ServiceLocator.ServiceProvider.GetService(typeof(ContractService)) as ContractService;
            _userService = ServiceLocator.ServiceProvider.GetService(typeof(UserService)) as UserService;
            _roomService = ServiceLocator.ServiceProvider.GetService(typeof(RoomService)) as RoomService;
            _billService = ServiceLocator.ServiceProvider.GetService(typeof(BillService)) as BillService;
            _contract = contract;
            _rooms = _contractService.GetAvailableRooms();
            _users = _userService.GetAllWithRoleTenant();
            
            SetUpComboBox();

            if (_contract != null) {
                SetUpData(_contract);
                Text = "Chỉnh sửa hợp đồng";
            }
            else {
                dateTimePickerContractStartDate.MinDate = DateTime.Now;
                dateTimePickerContractStartDate.Value = DateTime.Now;
            }
        }

        private void SetUpData(Contract contract) {
            // Cho phép sửa
            comboBoxContractTenant.SelectedItem = contract.User.Name;
            textBoxPrice.Text = contract.Price.ToString();

            // Không cho sửa
            comboBoxContractRoom.Items.Add(contract.Room.RoomNumber);
            comboBoxContractRoom.SelectedIndex = 1;
            var month = (contract.EndDate.Year - contract.StartDate.Year) * 12 + contract.EndDate.Month - contract.StartDate.Month; 
            comboBoxContractEndDate.Items.Add(month + " tháng");
            comboBoxContractEndDate.SelectedIndex = 1;
            comboBoxContractRoom.Enabled = false;
            comboBoxContractEndDate.Enabled = false;

            dateTimePickerContractStartDate.Value = contract.StartDate;
            dateTimePickerContractStartDate.Enabled = false;

            labelContractEndDate.Text = contract.EndDate.ToString("dd/MM/yyyy");
        }

        private void SetUpComboBox() {
            comboBoxContractRoom.Items.Add("None");
            comboBoxContractTenant.Items.Add("None");
            comboBoxContractPrice.Items.Add("None");
            comboBoxContractEndDate.Items.Add("None");

            comboBoxContractRoom.SelectedIndex = 0;
            comboBoxContractTenant.SelectedIndex = 0;
            comboBoxContractPrice.SelectedIndex = 0;
            comboBoxContractEndDate.SelectedIndex = 0;

            if (_contract == null) {
                SetUpComboBoxRoom();
                SetUpComboBoxEndDate();
            }

            SetUpComboBoxTenant();
            SetUpComboBoxPrice();
        }

        private void SetUpComboBoxRoom() {
            foreach (var room in _rooms) {
                comboBoxContractRoom.Items.Add(room.RoomNumber);
            }
        }

        private void SetUpComboBoxTenant() {
            foreach (var user in _users) {
                comboBoxContractTenant.Items.Add(user.Name);
            }

            comboBoxContractTenantEmail.Items.Add("None");
            comboBoxContractTenantEmail.SelectedIndex = 0;
        }

        private void SetUpComboBoxPrice() {
            comboBoxContractPrice.Items.Add("1.000.000");
            comboBoxContractPrice.Items.Add("1.500.000");
            comboBoxContractPrice.Items.Add("3.000.000");
            comboBoxContractPrice.Items.Add("5.000.000");
            comboBoxContractPrice.Items.Add("7.000.000");
            comboBoxContractPrice.Items.Add("10.000.000");
            comboBoxContractPrice.Items.Add("15.000.000");
            comboBoxContractPrice.Items.Add("20.000.000");
        }

        private void SetUpComboBoxEndDate() {
            comboBoxContractEndDate.Items.Add("1 tháng");
            comboBoxContractEndDate.Items.Add("3 tháng");
            comboBoxContractEndDate.Items.Add("6 tháng");
            comboBoxContractEndDate.Items.Add("12 tháng");
            comboBoxContractEndDate.Items.Add("18 tháng");
            comboBoxContractEndDate.Items.Add("24 tháng");
            comboBoxContractEndDate.Items.Add("36 tháng");
        }

        private void ButtonSave_Click(object sender, EventArgs e) {
            var roomId = _roomService.GetIdByRoomNumber(comboBoxContractRoom.Text);
            var userId = _userService.GetIdByNameAndEmail(comboBoxContractTenant.Text, comboBoxContractTenantEmail.Text);

            if (IsAllDataFilled() && IsContractSafeToSave()) {
                if (_contract == null) {
                    if (!_contractService.IsRoomAvailableWithToast(roomId)) return;
                    _contract = new Contract
                    {
                        RoomId = roomId,
                        UserId = userId,
                        Price = int.Parse(textBoxPrice.Text),
                        StartDate = dateTimePickerContractStartDate.Value,
                        EndDate = DateTime.ParseExact(labelContractEndDate.Text, "dd/MM/yyyy",
                            CultureInfo.CurrentCulture)
                    };
                    _contractService.Add(_contract);
                    _billService.GenerateMissingBillsForContract(_contract);
                }
                else {
                    _contract.UserId = userId;
                    _contract.Price = int.Parse(textBoxPrice.Text);
                    _contract.StartDate = dateTimePickerContractStartDate.Value;

                    _contractService.Update(_contract);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool IsAllDataFilled() {
            if (comboBoxContractTenant.SelectedIndex == 0) {
                new ToastForm("Vui lòng chọn người thuê", true).Show();
                return false;
            }

            if (comboBoxContractTenantEmail.SelectedIndex == 0) {
                new ToastForm("Vui lòng chọn email người thuê", true).Show();
                return false;
            }

            if (comboBoxContractRoom.SelectedIndex == 0) {
                new ToastForm("Vui lòng chọn căn hộ", true).Show();
                return false;
            }

            if (string.IsNullOrEmpty(textBoxPrice.Text)) {
                new ToastForm("Vui lòng nhập giá căn hộ", true).Show();
                return false;
            }

            if (!InputHelper.IsValidInputNumber(textBoxPrice.Text)) {
                new ToastForm("Vui lòng nhập giá căn hộ hợp lệ").Show();
                return false;
            }

            if (comboBoxContractEndDate.SelectedIndex == 0) {
                new ToastForm("Vui lòng chọn thời hạn", true).Show();
                return false;
            }

            return true;
        }

        private bool IsContractSafeToSave() {
            if (dateTimePickerContractStartDate.Value.Day > 28) {
                new ToastForm("Vui lòng chọn ngày bắt đầu nhỏ hơn 28.").Show();
                labelContractEndDate.Text = "Vui lòng chọn lại số tháng!";
                return false;
            }
            
            return true;
        }

        private void comboBoxPrice_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBoxContractPrice.Text.Equals("None")) {
                textBoxPrice.Text = "";
                return;
            }

            textBoxPrice.Text = comboBoxContractPrice.Text.Replace(".", "");
        }

        private void comboBoxEndDate_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBoxContractEndDate.Text.Equals("None")) {
                return;
            }

            var months = int.Parse(comboBoxContractEndDate.Text.Split(' ')[0]);
            var endDate = dateTimePickerContractStartDate.Value.AddMonths(months);
            labelContractEndDate.Text = endDate.ToString("dd/MM/yyyy");
        }

        private void buttonPlus_Click(object sender, EventArgs e) {
            textBoxPrice.Text = string.IsNullOrEmpty(textBoxPrice.Text)
                ? "500000"
                : (int.Parse(textBoxPrice.Text) + 500000).ToString();

            if (int.Parse(textBoxPrice.Text) < 0) {
                textBoxPrice.Text = "0";
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e) {
            textBoxPrice.Text = string.IsNullOrEmpty(textBoxPrice.Text)
                ? "500000"
                : (int.Parse(textBoxPrice.Text) - 500000).ToString();

            if (int.Parse(textBoxPrice.Text) < 0) {
                textBoxPrice.Text = "0";
            }
        }

        private void textBox_NumberInput(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void ContractForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (DialogResult != DialogResult.OK) {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void comboBoxContractTenant_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBoxContractTenant.SelectedIndex == 0) {
                return;
            }

            var users = _userService.GetAllEmailByName(comboBoxContractTenant.Text);

            comboBoxContractTenantEmail.Items.Clear();
            comboBoxContractTenantEmail.Items.Add("None");
            foreach (var user in users) {
                comboBoxContractTenantEmail.Items.Add(user);
            }

            if (comboBoxContractTenantEmail.Items.Count == 1) {
                comboBoxContractTenantEmail.SelectedIndex = 0;
            }
            else {
                comboBoxContractTenantEmail.SelectedIndex = 1;
            }
        }
    }
}