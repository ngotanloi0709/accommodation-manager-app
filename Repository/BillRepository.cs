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
            return Context.Set<Bill>().Where(bill => bill.UserId == userId).ToList();
        }
    }
}
