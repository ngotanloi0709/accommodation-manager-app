using AccommodationManagerApp.Model;
using System.Collections.Generic;
using System.Linq;

namespace AccommodationManagerApp.Repository
{
    public class BillRepository : Repository<Bill>
    {
        public BillRepository(AccommodationManagerAppContext context) : base(context) { }

        public List<Bill> GetAllBillByUserId(int userId)
        {
            return Context.Set<Bill>().Where(bill => bill.UserId == userId && bill.Status != BillStatus.Edit).ToList();
        }

        public List<Bill> GetByUserIdInThisMonthAnhUnpaid()
        {
            return Context.Set<Bill>().Where(bill => bill.CreatedAt.Month == System.DateTime.Now.Month && bill.Status == BillStatus.Unpaid).ToList();
        }

        public List<Bill> GetAllWithContractWithRoomAndUser() {
            return Context.Set<Bill>().Include("Contract").Include("Contract.Room").Include("Contract.User").ToList();
        }

        public List<Bill> GetAllByContractId(int contract_id) {
            return Context.Set<Bill>().Where(bill => bill.ContractId == contract_id).ToList();
        }
    }
}
