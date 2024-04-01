using System;
using AccommodationManagerApp.Model;

namespace AccommodationManagerApp.Util {
    public static class FixedPriceTypeHelper {
        public static string ToVietnamese(this FixedPriceType status) {
            switch (status) {
                case FixedPriceType.Water:
                    return "Tiền nước";
                case FixedPriceType.Electricity:
                    return "Tiền điện";
                case FixedPriceType.Internet:
                    return "Tiền Internet";
                default:
                    throw new ArgumentOutOfRangeException(nameof(status), status, null);
            }
        }

        public static FixedPriceType ToFixedPriceType(this string status) {
            switch (status) {
                case "Tiền nước":
                    return FixedPriceType.Water;
                case "Tiền điện":
                    return FixedPriceType.Electricity;
                case "Tiền Internet":
                    return FixedPriceType.Internet;
                default:
                    throw new ArgumentOutOfRangeException(nameof(status), status, null);
            }
        }
    }
}