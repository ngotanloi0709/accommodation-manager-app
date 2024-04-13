using System;

namespace AccommodationManagerApp.Util {
    public class InputHelper {
        public static bool IsValidInputNumber(string input) {
            return input.Length < 18 && long.TryParse(input, out _) && long.Parse(input) >= 0;
        }

        public static bool IsValidInputEmail(string input) {
            return input.Contains("@") && input.Contains(".");
        }
    }
}