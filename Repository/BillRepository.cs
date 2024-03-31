using AccommodationManagerApp.Model;

namespace AccommodationManagerApp.Repository
{
    public class BillRepository : Repository<Bill>
    {
        public BillRepository(AccommodationManagerAppContext context) : base(context) { }
        public void DeleteAll()
        {
            Context.Set<Bill>().RemoveRange(GetAll());
            Context.SaveChanges();
            Context.Database.ExecuteSqlCommand("ALTER TABLE bills AUTO_INCREMENT = 1;");
        }
    }
}
