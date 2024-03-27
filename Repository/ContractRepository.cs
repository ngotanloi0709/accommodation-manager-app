using System.Collections.Generic;
using System.Linq;
using AccommodationManagerApp.Model;

namespace AccommodationManagerApp.Repository {
    public class ContractRepository :Repository<Contract> {
        public ContractRepository(AccommodationManagerAppContext context) : base(context) { }

        public List<Contract> GetAllWithUserAndRoom() {
            return Context.Set<Contract>().Include("User").Include("Room").ToList();
        }
    }
}