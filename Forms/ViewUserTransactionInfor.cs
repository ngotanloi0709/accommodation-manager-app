using AccommodationManagerApp.Model;
using AccommodationManagerApp.Service;
using AccommodationManagerApp.Util;
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
    public partial class ViewUserTransactionInfor : BaseForm

    {
        private readonly UserService _userService;
        private readonly BillService _billService;
        private User _user;
        private List<Bill> Bills { get; set; }
        public ViewUserTransactionInfor(User user)
        {
            _userService = ServiceLocator.ServiceProvider.GetService(typeof(UserService)) as UserService;
            _billService = ServiceLocator.ServiceProvider.GetService(typeof(BillService)) as BillService;
            _user = user;
            InitializeComponent();
            LoadUserTransactionData();
        }

        private void LoadUserTransactionData()
        {
            ListViewUserTransaction.Items.Clear();
            List<Bill> bills = _billService.GetAllBillByUserIdIncludeEdit(_user.Id);
            Bills = bills;
            if (bills.Count != 0)
            {
                foreach (var bill in bills)
                {
                    ListViewItem item = new ListViewItem(bill.Id.ToString());
                    item.SubItems.Add(bill.ElectricityQuantity.ToString());
                    item.SubItems.Add(bill.WaterQuantity.ToString());
                    item.SubItems.Add(bill.Contract?.Room.RoomNumber ?? "Trống");
                    item.SubItems.Add(bill.DateOfBillFormatted);
                    item.SubItems.Add(bill.Status.ToVietnamese());
                    ListViewUserTransaction.Items.Add(item);
                }
            }
        }

        private void ListViewUserTransaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bill bill = IsSelectedBillValid();
            if(bill != null)
            {
                LabelBillContractOwner.Text = bill.Contract.User.Name;
                LabelBillContractValue.Text = FormatText.IntegerToVnd(bill.Contract.Price);
                LabelBillTotal.Text = FormatText.IntegerToVnd(bill.GetTotalPrice());
                LabelBillRoomNumber.Text = bill.Contract.Room.RoomNumber;
                LabelBillContractEndDate.Text = bill.Contract.EndDate.ToString("dd/MM/yyyy");
            }
            
        }

        private Bill IsSelectedBillValid()
        {
            if (ListViewUserTransaction.SelectedItems.Count > 0)
            {
                var index = ListViewUserTransaction.SelectedItems[0].Index;
                if (index < Bills.Count) return Bills[index];
            }

            return null; ;
        }
    }
}
