using System;
using System.Collections.Generic;
using System.Linq;
using AccommodationManagerApp.Model;

namespace AccommodationManagerApp.Repository {
    public class ContractRepository : Repository<Contract> {
        public ContractRepository(AccommodationManagerAppContext context) : base(context) { }

        public List<Contract> GetAllWithUserAndRoom() {
            return Context.Set<Contract>().Include("User").Include("Room").ToList();
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

        public List<Contract> GetByCustomizeQuery(List<object> start, List<object> end, List<string> text,
            bool? terminated)
        {
            bool startCondition = (bool)start[0];
            int? startMonth = (int?)start[1];
            int? endMonth = (int?)end[1];
            string userName = text[0];
            string roomNumber = text[1];

            var filteredContract = Context.Set<Contract>()
                .Include("User")
                .Include("Room")
                .Where(contract =>
                    (contract.StartDate < DateTime.Now || !startCondition) &&
                    (startMonth == null || contract.StartDate.Month >= startMonth) &&
                    (endMonth == null || contract.EndDate.Month <= endMonth) &&
                    (userName == null || userName.Equals(contract.User.Name, StringComparison.OrdinalIgnoreCase)) &&
                    (roomNumber == null ||
                     roomNumber.Equals(contract.Room.RoomNumber, StringComparison.OrdinalIgnoreCase)) &&
                    (terminated == null || contract.IsTerminated == !terminated)
                );
            return filteredContract.ToList();
        }

        public List<Contract> GetByRoomIdAndNonExpired(int roomId)
        {
            return Context.Set<Contract>().Where(c => c.RoomId == roomId && c.IsTerminated == false).ToList();
        }
    }
}