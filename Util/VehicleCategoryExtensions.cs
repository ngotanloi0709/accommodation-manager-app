using AccommodationManagerApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccommodationManagerApp.Util
{
    public static class VehicleCategoryExtensions
    {
        public static string ToVietnamese(this VehicleCategory category)
        {
            switch (category)
            {
                case VehicleCategory.two_wheel:
                    return "Xe hai bánh";
                case VehicleCategory.four_wheel:
                    return "Xe bốn bánh";
                case VehicleCategory.three_wheel:
                    return "Xe ba bánh";
                case VehicleCategory.bicycle:
                    return "Xe đạp";
                case VehicleCategory.electric_bicycle:
                    return "Xe đạp điện";
                default:
                    throw new ArgumentOutOfRangeException(nameof(category), category, null);
            }
        }

        public static VehicleCategory ToVehicleCategory(this string category)
        {
            switch (category)
            {
                case "Xe hai bánh":
                    return VehicleCategory.two_wheel;
                case "Xe bốn bánh":
                    return VehicleCategory.four_wheel;
                case "Xe ba bánh":
                    return VehicleCategory.three_wheel;
                case "Xe đạp":
                    return VehicleCategory.bicycle;
                case "Xe đạp điện":
                    return VehicleCategory.electric_bicycle;
                default:
                    throw new ArgumentOutOfRangeException(nameof(category), category, null);
            }
        }
    }
}
