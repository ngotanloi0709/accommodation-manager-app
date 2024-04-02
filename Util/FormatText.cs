using System.Globalization;

namespace AccommodationManagerApp.Util {
    public class FormatText {
        public static string IntegerToVnd(int number)
        {
            var cultureInfo = new CultureInfo("vi-VN");
            return number.ToString("C0", cultureInfo);
        }
    }
}