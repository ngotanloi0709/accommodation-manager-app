using System.Collections.Generic;
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Repository;


namespace AccommodationManagerApp.Service {
    public class UserService {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository) {
            _userRepository = userRepository;
        }

        public User GetUserByEmail(string email) {
            return _userRepository.GetByEmail(email);
        }

        public List<User> GetAll() {
            return _userRepository.GetAll();
        }

        public int? GetIdByName(string name) {
            User user = _userRepository.GetByName(name);

            if (user != null) {
                return user.Id;
            }

            return null;
        }
    }
}