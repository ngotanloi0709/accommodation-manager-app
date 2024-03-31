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
                case VehicleCategory.TwoWheel:
                    return "Xe hai bánh";
                case VehicleCategory.FourWheel:
                    return "Xe bốn bánh";
                case VehicleCategory.ThreeWheel:
                    return "Xe ba bánh";
                case VehicleCategory.Bicycle:
                    return "Xe đạp";
                case VehicleCategory.ElectricBicycle:
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
                    return VehicleCategory.TwoWheel;
                case "Xe bốn bánh":
                    return VehicleCategory.FourWheel;
                case "Xe ba bánh":
                    return VehicleCategory.ThreeWheel;
                case "Xe đạp":
                    return VehicleCategory.Bicycle;
                case "Xe đạp điện":
                    return VehicleCategory.ElectricBicycle;
                default:
                    throw new ArgumentOutOfRangeException(nameof(category), category, null);
            }
        }
    }
}
