using System.Linq;
using AccommodationManagerApp.Model;

namespace AccommodationManagerApp.Repository {
    public class BuildingRepository : Repository<Building> {
        public BuildingRepository(AccommodationManagerAppContext context) : base(context) 
        {
        }

        public Building GetByName(string name) {
            return Context.Set<Building>().FirstOrDefault(b => b.Name == name);
        }
    }
}