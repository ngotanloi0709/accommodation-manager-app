using System.Linq;
using AccommodationManagerApp.Models;

namespace AccommodationManagerApp.Repository {
    public class UserRepository  : Repository<User> {
        public UserRepository(AccommodationManagerAppContext context) : base(context)
        {
        }

        public User GetByEmail(string email) {
            return Context.Set<User>().FirstOrDefault(u => u.Email == email);
        }
    }
}