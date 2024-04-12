using System.Collections.Generic;
using System.Linq;
using AccommodationManagerApp.Model;

namespace AccommodationManagerApp.Repository {
    public class RoomRepository : Repository<Room> {
        public RoomRepository(AccommodationManagerAppContext context) : base(context) {}

        public IEnumerable<Room> GetAllWithBuildingAndUserAndContractWithUser() {
            return Context.Set<Room>().Include("Building").Include("Users").Include("Contracts").Include("Contracts.User").ToList();
        }

        public Room GetByRoomNumber(string roomNumber) {
            return Context.Set<Room>().FirstOrDefault(r => r.RoomNumber == roomNumber);
        }


        public Room GetByIdWithContract(int? id) {
            return Context.Set<Room>().Include("Contracts").FirstOrDefault(r => r.Id == id);
        }



        public List<Room> GetAllWithBuildingId(int buildingId)
        {
            return Context.Set<Room>().Where(r => r.BuildingId == buildingId).ToList();
        }

        public List<Room> GetAllWithBuildingIdAndNotTerminatedContract(int buildingId)
        {
            return Context.Set<Room>().Include("Contracts").Where(r => r.BuildingId == buildingId && r.Contracts.Any(c => c.IsTerminated == false)).ToList();
        }

        public IEnumerable<Room> GetAllWithNotTerminatedContract() {
            return Context.Set<Room>().Include("Contracts").Where(r => r.Contracts.Any(c => c.IsTerminated == false)).ToList();
        }
    }
}