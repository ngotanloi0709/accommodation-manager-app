using AccommodationManagerApp.Models;
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
    }
}