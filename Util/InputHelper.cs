using System;

namespace AccommodationManagerApp.Util {
    public class InputHelper {
        public static bool IsValidInputNumber(string input) {
            return int.TryParse(input, out _) && int.Parse(input) >= 0;
        }
        
        public static bool IsValidInputEmail(string input) {
            return input.Contains("@") && input.Contains(".");
        }
    }
}