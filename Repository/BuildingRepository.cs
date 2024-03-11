using AccommodationManagerApp.Model;

namespace AccommodationManagerApp.Repository {
    public class BuildingRepository : Repository<Building> {
        public BuildingRepository(AccommodationManagerAppContext context) : base(context) 
        {
        }
    }
}