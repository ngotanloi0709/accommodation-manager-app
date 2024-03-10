using System;
using System.Windows.Forms;
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
            Console.WriteLine(PasswordHelper.HashPassword(password));
            if (result) {
                CurrentUser = user;
            }
            
            return result;
        }
        
        public bool IsAuthenticated() {
            return CurrentUser != null;
        }
    }
}