using System.Collections.Generic;
using System.Linq;
using AccommodationManagerApp.Model;

namespace AccommodationManagerApp.Repository {
    public class RoomRepository : Repository<Room> {
        public RoomRepository(AccommodationManagerAppContext context) : base(context) {}

        public List<Room> GetAllWithBuildingAndContractWithUser() {
            return Context.Set<Room>().Include("Building").Include("Contracts").Include("Contracts.User").ToList();
        }

        public Room GetByRoomNumber(string roomNumber) {
            return Context.Set<Room>().FirstOrDefault(r => r.RoomNumber == roomNumber);
        }

        public Room GetByIdWithContract(int? id) {
            return Context.Set<Room>().Include("Contracts").FirstOrDefault(r => r.Id == id);
        }
    }
}