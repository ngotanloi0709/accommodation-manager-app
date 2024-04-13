using System;
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

        public Room GetByIdWithContract(int? id) => Context.Set<Room>().Include("Contracts").FirstOrDefault(r => r.Id == id);

        public List<Room> GetAllWithBuildingId(int buildingId) => Context.Set<Room>().Where(r => r.BuildingId == buildingId).ToList();

        public IEnumerable<Room> GetAllWithNotTerminatedContract()  => Context.Set<Room>().Include("Contracts").Where(r => r.Contracts.Any(c => c.IsTerminated == false)).ToList();

        public List<Room> GetByCustomizeQuery(string building, RoomStatus state, List<string> text)
        {
            var text0 = text[0];
            var text1 = text[1];

            var filteredRooms = Context.Set<Room>()
                .Include("Building")
                .Include("Users")
                .Include("Contracts")
                .Include("Contracts.User")
                .Where(room =>
                (building == null || room.Building.Name == building) &&
                (state == RoomStatus.Null || room.Status == state) &&
                (text0 == null) &&
                (text1 == null || text1.Equals(room.RoomNumber, StringComparison.OrdinalIgnoreCase))
            );
            return filteredRooms.ToList();

        }
    }
}