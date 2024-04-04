using System.Collections.Generic;
using System.Linq;
using AccommodationManagerApp.Model;

namespace AccommodationManagerApp.Repository {
    public class ContractRepository : Repository<Contract> {
        public ContractRepository(AccommodationManagerAppContext context) : base(context) { }

        public List<Contract> GetAllWithUserAndRoom() {
            return Context.Set<Contract>().Include("User").Include("Room").ToList();
        }

        public Contract GetById(int? id)
        {
            return Context.Set<Contract>().FirstOrDefault(c => c.Id == id);
        }

        public List<Contract> GetByUserId(int userId) {
            return Context.Set<Contract>().Where(c => c.UserId == userId).ToList();
        }

        public List<Contract> GetByRoomId(int roomId) {
            return Context.Set<Contract>().Where(c => c.RoomId == roomId).ToList();
        }

        public List<Contract> GetByUserIdAndNonExpiredWithRoom(int userId) {
            return Context.Set<Contract>().Include("Room").Where(c => c.UserId == userId && c.IsTerminated == false).ToList();
        }
    }
}