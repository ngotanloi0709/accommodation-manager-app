using AccommodationManagerApp.Service;
using System.Collections.Generic;
using System.Windows.Forms;
using Contract = AccommodationManagerApp.Model.Contract;
using Room = AccommodationManagerApp.Model.Room;
using BillModel = AccommodationManagerApp.Model.Bill;
using System.Linq;
using System;

namespace AccommodationManagerApp.Forms.Bill
{
    public partial class BillForm : BaseForm
    {
        private readonly BillModel _bill;
        private readonly RoomService _roomService;
        private readonly BillService _billService;
        private readonly List<Room> _rooms;
        private Contract _contract;
        public BillForm(BillModel bill)
        {
            InitializeComponent();
            _billService = ServiceLocator.ServiceProvider.GetService(typeof(BillService)) as BillService;
            _roomService = ServiceLocator.ServiceProvider.GetService(typeof(RoomService)) as RoomService;
            _rooms = _roomService.GetAll();
            SetUpComboBoxRoom();
            _bill = bill;
            if (_bill != null)
                LoadData();
        }
        private void buttonSave_Click(object sender, System.EventArgs e)
        {
            var confirmationForm = new ConfirmationForm("Xác nhận cập nhật");
            confirmationForm.ShowDialog();
            if(confirmationForm.DialogResult == DialogResult.Yes)
            {
                CheckInput();
                if (_bill == null)
                {
                    int electric = int.Parse(txtbxElectric.Text);
                    int water = int.Parse(txtbxWater.Text);
                    _contract = SelectContract();
                    _billService.Add(new BillModel(electric, water, _contract.Id));
                }
                else
                {
                    _bill.ElecQuantity = int.Parse(txtbxElectric.Text);
                    _bill.WaterQuantity = int.Parse(txtbxWater.Text);
                    _billService.Update(_bill.Id, _bill);
                }
                new ToastForm("Cập nhật thành công");
                Close();
            }
        }
        // -------------------------------------------------------------------------------------------
        private void CheckInput()
        {
            if (string.IsNullOrWhiteSpace(txtbxElectric.Text) ||
                string.IsNullOrWhiteSpace(txtbxWater.Text) || 
                comboBoxRoom.SelectedItem?.ToString() == "Số Phòng")
            {
                new ToastForm("Mời điền đầy đủ thông tin", true);
                return;
            }
        }
        private void LoadData()
        {
            comboBoxRoom.Enabled = false;
            comboBoxRoom.Text = _bill.Contract.Room.RoomNumber;
            labelRent.Text = "Giá Phòng: " + _bill.Contract.Price.ToString();
            txtbxElectric.Text = _bill.ElecQuantity.ToString();
            txtbxWater.Text = _bill.WaterQuantity.ToString();
            lblDate.Text = _bill.CreatedAtFormatted.ToString();
        }
        private void comboBoxRoom_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            _contract = SelectContract();
            if (_contract == null)
            {
                labelRent.Text = "Giá phòng: ";
                new ToastForm("Mời bạn chọn số phòng phù hợp", true);
            }
            else
            {
                labelRent.Text = "Giá Phòng: " + _contract.Price.ToString();
            }
        }
        private Contract SelectContract()
        {
            string numberRoom = comboBoxRoom.SelectedItem.ToString();
            Room _room = _rooms.FirstOrDefault(room => room.RoomNumber == numberRoom);
            return _room?.Contracts.LastOrDefault();
        }
        private void SetUpComboBoxRoom()
        {
            comboBoxRoom.Items.Add("Số Phòng");

            comboBoxRoom.Items.AddRange(_rooms.Select(room => room.RoomNumber).ToArray());
        }
        private void btnClose_Click(object sender, System.EventArgs e)
        {
            ConfirmationForm confirmationForm = new ConfirmationForm("Bạn có muốn thoát không ?");
            confirmationForm.ShowDialog();
            if (confirmationForm.DialogResult != DialogResult.Yes) return;
            Close();
        }
        private void txtbxWater_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
