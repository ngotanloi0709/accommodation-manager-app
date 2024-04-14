using AccommodationManagerApp.Model;
using AccommodationManagerApp.Service;
using AccommodationManagerApp.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms {
    public partial class ViewUserTransactionInformation : BaseForm {
        private readonly BillService _billService;
        private readonly User _user;
        private List<Bill> Bills { get; set; }

        public ViewUserTransactionInformation(User user) {
            InitializeComponent();
            ListViewUserTransaction.View = View.Details;
            
            _billService = ServiceLocator.ServiceProvider.GetService(typeof(BillService)) as BillService;
            _user = user;
            
            LoadUserTransactionData();
        }

        private void LoadUserTransactionData() {
            ListViewUserTransaction.Items.Clear();
            var bills = _billService.GetAllBillByUserIdIncludeEdit(_user.Id);
            
            Bills = bills;
            if (bills.Count == 0) return;
            
            foreach (var bill in bills) {
                var item = new ListViewItem(bill.Id.ToString());
                item.SubItems.Add(bill.ElectricityQuantity.ToString());
                item.SubItems.Add(bill.WaterQuantity.ToString());
                item.SubItems.Add(bill.Contract?.Room.RoomNumber ?? "Trống");
                item.SubItems.Add(bill.DateOfBillFormatted);
                item.SubItems.Add(bill.Status.ToVietnamese());
                ListViewUserTransaction.Items.Add(item);
            }
        }

        private void ListViewUserTransaction_SelectedIndexChanged(object sender, EventArgs e) {
            var bill = IsSelectedBillValid();
            
            if (bill == null) return;
            
            LabelBillContractOwner.Text = bill.Contract.User.Name;
            LabelBillContractValue.Text = FormatText.IntegerToVnd(bill.Contract.Price);
            LabelBillTotal.Text = FormatText.IntegerToVnd(bill.GetTotalPrice());
            LabelBillRoomNumber.Text = bill.Contract.Room.RoomNumber;
            LabelBillContractEndDate.Text = bill.Contract.EndDate.ToString("dd/MM/yyyy");
        }

        private Bill IsSelectedBillValid() {
            if (ListViewUserTransaction.SelectedItems.Count <= 0) return null;
            
            var index = ListViewUserTransaction.SelectedItems[0].Index;
            
            return index < Bills.Count ? Bills[index] : null;
        }
    }
}