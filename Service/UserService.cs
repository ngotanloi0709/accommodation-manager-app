using System;
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
        
        public List<User> GetAllWithRoom() {
            return _userRepository.GetAllWithRoom();
        }

        public int? GetIdByName(string name) {
            User user = _userRepository.GetByName(name);

            if (user != null) {
                return user.Id;
            }

            return null;
        }

        public bool IsEmailExists(string text) {
            return _userRepository.GetByEmail(text) != null;
        }

        public void Add(User user) {
            _userRepository.Add(user);
        }

        public void Update(int userId, User user) {
            _userRepository.Update(userId, user);
        }

        public bool Delete(int userId) {
            try {
                _userRepository.Delete(userId);
                return true;
            }
            catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }
        }
    }
}