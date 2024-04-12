using System;
using AccommodationManagerApp.Model;

namespace AccommodationManagerApp.Util {
    public static class RoomStatusExtensions {
        public static string ToVietnamese(this RoomStatus status) {
            switch (status) {
                case RoomStatus.Normal:
                    return "Bình thường";
                case RoomStatus.UnderMaintenance:
                    return "Đang bảo dưỡng";
                default:
                    throw new ArgumentOutOfRangeException(nameof(status), status, null);
            }
        }

        public static RoomStatus ToRoomStatus(this string status) {
            switch (status) {
                case "Bình thường":
                    return RoomStatus.Normal;
                case "Đang bảo dưỡng":
                    return RoomStatus.UnderMaintenance;
                default:
                    return RoomStatus.Null;
            }
        }
    }
}