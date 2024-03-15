using System;
using AccommodationManagerApp.Model;

namespace AccommodationManagerApp.Util {
    public static class RoomStatusExtensions {
        public static string ToVietnamese(this RoomStatus status) {
            switch (status) {
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

        public static RoomStatus ToRoomStatus(this string status) {
            switch (status) {
                case "Trống":
                    return RoomStatus.Empty;
                case "Đang bảo dưỡng":
                    return RoomStatus.UnderMaintenance;
                case "Đã thuê":
                    return RoomStatus.Rented;
                default:
                    throw new ArgumentOutOfRangeException(nameof(status), status, null);
            }
        }
    }
}