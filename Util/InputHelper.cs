using System;

namespace AccommodationManagerApp.Util {
    public class InputHelper {
        public static bool IsValidPrice(string input) {
            return int.TryParse(input, out _) && int.Parse(input) >= 0;
        }
    }
}