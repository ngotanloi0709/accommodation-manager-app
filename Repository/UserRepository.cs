using System.Collections.Generic;
using System.Linq;
using AccommodationManagerApp.Model;

namespace AccommodationManagerApp.Repository {
    public class UserRepository : Repository<User> {
        public UserRepository(AccommodationManagerAppContext context) : base(context) { }

        public User GetByEmail(string email) {
            return Context.Set<User>().FirstOrDefault(u => u.Email == email);
        }

        public User GetByName(string name) {
            return Context.Set<User>().FirstOrDefault(u => u.Name == name);
        }

        public List<User> GetAllWithContract() {
            return Context.Set<User>().Include("Contracts").ToList();
        }
    }
}