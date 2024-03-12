using System;
using AccommodationManagerApp.Model;

namespace AccommodationManagerApp.Util {
    public static class RoomStatusExtensions
    {
        public static string ToVietnamese(this RoomStatus status)
        {
            switch (status)
            {
                case RoomStatus.Empty:
                    return "Trống";
                case RoomStatus.UnderMaintenance:
                    return "Đang bảo dưỡng";
                case RoomStatus.Rented:
                    return "Đã thuê";
                default:
                    throw new ArgumentOutOfRangeException(nameof(status), status, null);
            }
        }
    }
}