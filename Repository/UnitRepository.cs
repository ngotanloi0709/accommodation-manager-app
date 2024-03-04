using AccommodationManagerApp.Models;

namespace AccommodationManagerApp.Repository {
    public class UnitRepository : Repository<Unit> {
        public UnitRepository(AccommodationManagerAppContext context) : base(context)
        {
        }
    }
}