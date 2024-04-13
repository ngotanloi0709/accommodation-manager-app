using AccommodationManagerApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AccommodationManagerApp.Repository
{
    public class BillRepository : Repository<Bill>
    {
        public BillRepository(AccommodationManagerAppContext context) : base(context) { }

        public List<Bill> GetAllByUserIdWithContractWithRoomAndUser(int userId)
        {
            return Context.Set<Bill>()
                .Include("Contract")
                .Include("Contract.Room")
                .Include("Contract.User")
                .Where(bill => bill.Contract.UserId == userId)
                .ToList();
        }

        public List<Bill> GetAllBillByUserIdIncludeEdit(int userId)
        {
            return Context.Set<Bill>().Where(bill => bill.UserId == userId).ToList();
        }

        public List<Bill> GetByUserIdInThisMonthAnhUnpaid() => Context.Set<Bill>().Where(bill => bill.DateOfBill.Month == System.DateTime.Now.Month && bill.Status == BillStatus.Unpaid).ToList();

        public List<Bill> GetAllWithContractWithRoomAndUser() => Context.Set<Bill>().Include("Contract").Include("Contract.Room").Include("Contract.User").ToList();
        
        
        public List<Bill> GetAllByContractId(int contract_id)
        {
            return Context.Set<Bill>().Where(bill => bill.ContractId == contract_id).ToList();
        }

        public List<Bill> GetBillUnpaidByMonthAndYear(int month, int year)
        {
            return Context.Set<Bill>().Where(bill => bill.DateOfBill.Month == month && bill.DateOfBill.Year == year && bill.Status == BillStatus.Unpaid).ToList();
        }

        public List<Bill> GetBillPaidByMonthAndYear(int month, int year)
        {
            return Context.Set<Bill>().Where(bill => bill.DateOfBill.Month == month && bill.DateOfBill.Year == year && bill.Status == BillStatus.Paid).ToList();
        }

        public List<Bill> GetBillIsUpdatedByMonthAndYear(int month, int year)
        {
            return Context.Set<Bill>().Where(bill => bill.DateOfBill.Month == month && bill.DateOfBill.Year == year && bill.Status == BillStatus.Edit).ToList();

        }

        public List<Bill> GetBillByStatus(BillStatus status) => Context.Set<Bill>().Where(bill => bill.Status == status).ToList(); 
        
        public List<Bill> GetAllUnpaidBill() {
            return Context.Set<Bill>().Include("User").Where(bill => bill.Status == BillStatus.Unpaid).ToList();
        }

        public List<Bill> GetByCustomizeQuery(BillStatus state, List<object> time, List<string> text, int? minPrice,
            int? maxPrice)
        {
            bool time0 = (bool)time[0];
            int? time1 = time[1] as int?;
            int? time2 = time[2] as int?;
            string text0 = text[0];
            string text1 = text[1];

            var filteredBills = Context.Set<Bill>()
                .Include("Contract")
                .Include("Contract.Room")
                .Include("Contract.User")
                .Where(bill =>
                    (bill.Status == state || state == BillStatus.Null) &&
                    (bill.DateOfBill < DateTime.Now || !time0) &&
                    (time1 == null || bill.DateOfBill.Month == time1) &&
                    (time2 == null || bill.DateOfBill.Year == time2) &&
                    (text0 == null || text0.Equals(bill.Contract.User.Name, StringComparison.OrdinalIgnoreCase)) &&
                    (text1 == null ||
                     text1.Equals(bill.Contract.Room.RoomNumber, StringComparison.OrdinalIgnoreCase)) &&
                    (minPrice == null || bill.RentFee >= minPrice) &&
                    (maxPrice == null || bill.RentFee <= maxPrice)
                );
            return filteredBills.ToList(); 
        }

        public List<Bill> GetAllByUserId(int userId) {
            return Context.Set<Bill>().Where(bill => bill.User.Id == userId).ToList();
        }
    }
}
