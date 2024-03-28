using System.Collections.Generic;
using System.Linq;
using AccommodationManagerApp.Model;

namespace AccommodationManagerApp.Repository {
    public class ContractRepository :Repository<Contract> {
        public ContractRepository(AccommodationManagerAppContext context) : base(context) { }

        public List<Contract> GetAllWithUserAndRoom() {
            return Context.Set<Contract>().Include("User").Include("Room").ToList();
        }

        public List<Contract> GetByUserId(int userId) {
            return Context.Set<Contract>().Where(c => c.UserId == userId).ToList();
        }
        
        public List<Bill> GetByRoomId(int roomId) {
            return Context.Set<Bill>().Where(c => c.RoomId == roomId).ToList();
        }
    }
}