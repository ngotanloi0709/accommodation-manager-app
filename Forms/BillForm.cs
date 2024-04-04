using AccommodationManagerApp.Model;
using AccommodationManagerApp.Service;
using AccommodationManagerApp.Util;
using System;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms
{
    public partial class BillForm : BaseForm
    {
        private readonly Bill _bill;
        private readonly BillService _billService;
        private readonly VehicleService _vehicleService;
        private int _contractRentPrice;
        private int _fixedWaterPrice;
        private int _fixedElectricityPrice;
        private int _fixedInternetPrice;
        private int _generatedVehiclePrice;


        public BillForm(Bill bill, int fixedWaterPrice, int fixedElectricityPrice, int fixedInternetPrice)
        {
            InitializeComponent();
            
            _billService = ServiceLocator.ServiceProvider.GetService(typeof(BillService)) as BillService;
            _vehicleService = ServiceLocator.ServiceProvider.GetService(typeof(VehicleService)) as VehicleService;
            
            _bill = bill;
            _fixedWaterPrice = fixedWaterPrice;
            _fixedElectricityPrice = fixedElectricityPrice;
            _fixedInternetPrice = fixedInternetPrice;
            _contractRentPrice = _bill.Contract.Price;
            _generatedVehiclePrice = _vehicleService.GenerateVehicleFeeByRoomId(_bill.Contract.RoomId);

            SetUpComboBoxRoom();
            LoadData();
        }

        private void SetUpComboBoxRoom()
        {
            ComboBoxRoom.Items.Add("Chọn số phòng");
            ComboBoxRoom.Items.Add(_bill.Contract.Room.RoomNumber);
            ComboBoxRoom.SelectedIndex = 1;
            ComboBoxRoom.Enabled = false;
        }

        private void LoadData()
        {
            LabelRentFee.Text = FormatText.IntegerToVnd(_contractRentPrice);
            LabelDate.Text = _bill.DateOfBillFormatted;

            TextBoxRent.Text = _bill.RentFee.ToString();
            TextBoxElectricity.Text = _bill.ElectricityQuantity.ToString();
            TextboxWater.Text = _bill.WaterQuantity.ToString();
            TextBoxInternet.Text = _bill.InternetFee.ToString();
            TextBoxVehicle.Text = _bill.VehicleFee.ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!IsInputAllFilled()) return;

            var currentRentFee = int.Parse(TextBoxRent.Text);
            var currentElectricityFee = _fixedElectricityPrice;
            var currentWaterFee = _fixedWaterPrice;
            var currentInternetFee = int.Parse(TextBoxInternet.Text);
            var currentVehicleFee = int.Parse(TextBoxVehicle.Text);

            _bill.RentFee = currentRentFee;
            _bill.ElectricityFee = currentElectricityFee;
            _bill.WaterFee = currentWaterFee;
            _bill.InternetFee = currentInternetFee;
            _bill.VehicleFee = currentVehicleFee;
            _bill.ElectricityQuantity = int.Parse(TextBoxElectricity.Text);
            _bill.WaterQuantity = int.Parse(TextboxWater.Text);
            _bill.Status = BillStatus.Unpaid;
            _billService.Update(_bill.Id, _bill);

            new ToastForm("Cập nhật thành công").Show();
            Close();
        }

        private bool IsInputAllFilled()
        {
            if (string.IsNullOrEmpty(TextBoxRent.Text))
            {
                new ToastForm("Mời nhập số tiền thuê!", true).Show();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TextBoxInternet.Text))
            {
                new ToastForm("Mời nhập số tiền Internet!", true).Show();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TextBoxVehicle.Text))
            {
                new ToastForm("Mời nhập số tiền gửi xe!", true).Show();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TextboxWater.Text))
            {
                new ToastForm("Mời nhập số  nước!", true).Show();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TextBoxElectricity.Text))
            {
                new ToastForm("Mời nhập số điện!", true).Show();
                return false;
            }

            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtbxWater_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void buttonSkipRent_Click(object sender, EventArgs e)
        {
            TextBoxRent.Text = "0";
        }

        private void buttonSkipWater_Click(object sender, EventArgs e)
        {
            TextboxWater.Text = "0";
        }

        private void buttonSkipElectricity_Click(object sender, EventArgs e)
        {
            TextBoxElectricity.Text = "0";
        }

        private void buttonSkipInternet_Click(object sender, EventArgs e)
        {
            TextBoxInternet.Text = "0";
        }

        private void buttonSkipVehicle_Click(object sender, EventArgs e)
        {
            TextBoxVehicle.Text = "0";
        }

        private void buttonReloadVehicle_Click(object sender, EventArgs e)
        {
            TextBoxVehicle.Text = _generatedVehiclePrice.ToString();
        }

        private void ButtonLoadContractRentPrice_Click(object sender, EventArgs e)
        {
            TextBoxRent.Text = _contractRentPrice.ToString();
        }

        private void ButtonReloadInternet_Click(object sender, EventArgs e)
        {
            TextBoxInternet.Text = _fixedInternetPrice.ToString();
        }

        private void BillForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}