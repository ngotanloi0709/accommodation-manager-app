using System.Collections.Generic;
using System.Linq;
using AccommodationManagerApp.Model;

namespace AccommodationManagerApp.Repository {
    public class RoomRepository : Repository<Room> {
        public RoomRepository(AccommodationManagerAppContext context) : base(context)
        {
        }

        public Room GetByIdWithBuilding(int id) {
            return Context.Set<Room>().Include("Building").FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Room> GetAllWithBuilding() {
            return Context.Set<Room>().Include("Building").ToList();
        }
        
        public IEnumerable<Room> GetAllByBuildingId(int buildingId) {
            return Context.Set<Room>().Where(r => r.BuildingId == buildingId).ToList();
        }
    }
}