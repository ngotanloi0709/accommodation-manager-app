using System.Globalization;

namespace AccommodationManagerApp.Util {
    public class FormatText {
        public static string IntegerToVnd(int number)
        {
            CultureInfo cultureInfo = new CultureInfo("vi-VN");
            return number.ToString("C0", cultureInfo);
        }
    }
}