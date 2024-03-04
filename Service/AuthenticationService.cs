using System;
using AccommodationManagerApp.Models;
using AccommodationManagerApp.Util;


namespace AccommodationManagerApp.Service {
    public class AuthenticationService {
        private User CurrentUser { get; set; }
        private UserService UserService;
        
        public AuthenticationService(UserService userService) {
            this.UserService = userService;
        }
        
        public bool Authenticate(string email, string password) {
            User user = UserService.GetUserByEmail(email);
            bool result = user != null && user.Password == PasswordHelper.HashPassword(password);
            
            if (result) {
                CurrentUser = user;
                Console.WriteLine("Đăng nhập thành công");
            }
            
            return result;
        }
        
        public bool IsAuthenticated() {
            return CurrentUser != null;
        }
    }
}