using System;
using System.Collections.Generic;
using System.Linq;
using AccommodationManagerApp.Model;

namespace AccommodationManagerApp.Repository {
    public class UserRepository : Repository<User> {
        public UserRepository(AccommodationManagerAppContext context) : base(context) { }

        public User GetByEmail(string email) {
            return Context.Set<User>().FirstOrDefault(u => u.Email == email);
        }

        public User GetByNameAndEmail(string name, string email) {
            return Context.Set<User>().FirstOrDefault(u => u.Name == name && u.Email == email && u.Role == UserRole.Tenant);
        }

        public List<User> GetAllWithRoleTenantAndWithContractAndRoom() {
            return Context.Set<User>().Include("Contracts").Include("Room").Where(u => u.Role == UserRole.Tenant).ToList();
        }

        public List<User> GetAllWithRoleTenant() {
            return Context.Set<User>().Where(u => u.Role == UserRole.Tenant).ToList();
        }

        public User GetByName(string name) => Context.Set<User>().FirstOrDefault(user => user.Name == name);
        public List<User> GetAllByName(string name) {
            return Context.Set<User>().Where(u => u.Name.Contains(name) && u.Role == UserRole.Tenant).ToList();
        }

        public List<User> GetAllWithRoleNotTenantAndWithContractAndRoom() {
            return Context.Set<User>().Include("Contracts").Include("Room").Where(u => u.Role != UserRole.Tenant).ToList();
        }

        public List<User> GetByCustomizeQuery(bool? isFemale, List<string> text)
        {
            string name = text[0];
            string phone = text[1];
            string identityNumber = text[2];
            string email = text[3];
            int year = int.TryParse(text[4], out int parsedYear) ? parsedYear : 0;

            var filteredUsers = Context.Set<User>()
                .Include("Contracts")
                .Include("Room")
                .Where(user =>
                (user.Role == UserRole.Tenant) &&
                (user.IsFemale == isFemale || isFemale == null) &&
                (string.IsNullOrEmpty(name) || name.Equals(user.Name, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(phone) || phone.Equals(user.Phone, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(identityNumber) || identityNumber.Equals(user.IdentityNumber, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(email) || email.Equals(user.Email, StringComparison.OrdinalIgnoreCase)) &&
                (year == 0 || year == user.DateOfBirth.Year)
            );

            return filteredUsers.ToList();
        }

    }
}