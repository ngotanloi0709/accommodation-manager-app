using AccommodationManagerApp.Model;
using AccommodationManagerApp.Service;
using System;

namespace AccommodationManagerApp.Forms {
    public partial class ViewUserInformation : BaseForm {
        private readonly ContractService _contractService;
        private readonly BillService _billService;
        private readonly User _user;

        public ViewUserInformation(User user) {
            InitializeComponent();
            
            _contractService = ServiceLocator.ServiceProvider.GetService(typeof(ContractService)) as ContractService;
            _billService = ServiceLocator.ServiceProvider.GetService(typeof(BillService)) as BillService;
            _user = user;
            
            if (_user == null) {
                new ToastForm("Đã xảy ra lỗi", true).Show();
                Close();
            }
        }

        private void btnCheckVehicles_Click(object sender, EventArgs e) {
            if (_contractService.GetByUserIdAndNonExpiredWithRoom(_user.Id).Count == 0) {
                new ToastForm("Người thuê này không có hợp đồng với phòng nào", true).Show();
                return;
            }
            
            var viewUserVehicleInfor = new ViewUserVehicleInformation(_user);
            viewUserVehicleInfor.ShowDialog();
        }

        private void btnTransactionHistory_Click(object sender, EventArgs e) {
            if (_billService.GetAllByUserId(_user.Id).Count == 0) {
                new ToastForm("Người thuê này lịch sử giao dịch nào", true).Show();
                return;
            }
            
            var viewUserTransactionInfor = new ViewUserTransactionInformation(_user);
            viewUserTransactionInfor.ShowDialog();
        }

        private void btnRoomInfor_Click(object sender, EventArgs e) {
            if (_contractService.GetByUserIdAndNonExpiredWithRoom(_user.Id).Count == 0) {
                new ToastForm("Người thuê này không có hợp đồng nào", true).Show();
                return;
            }
            
            var viewUserRoomInfor = new ViewUserRoomInformation(_user);
            viewUserRoomInfor.ShowDialog();
        }
    }
}