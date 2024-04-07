using AccommodationManagerApp.Model;
using System;

namespace AccommodationManagerApp.Util
{
    public static class BillStatusExtensions
    {
        public static string ToVietnamese(this BillStatus status)
        {
            switch (status)
            {
                case BillStatus.Edit:
                    return "Đang Chỉnh Sửa";
                case BillStatus.Unpaid:
                    return "Chưa Thanh Toán";
                case BillStatus.Paid:
                    return "Đã Thanh Toán";
                default:
                    throw new ArgumentOutOfRangeException(nameof(status), status, null);
            }
        }
        public static BillStatus ToBillStatus(this string status)
        {
            switch (status)
            {
                case "Đang Chỉnh Sửa":
                    return BillStatus.Edit;
                case "Chưa Thanh Toán":
                    return BillStatus.Unpaid;
                case "Đã Thanh Toán":
                    return BillStatus.Paid;
                default:
                    throw new ArgumentOutOfRangeException(nameof(status), status, null);
            }
        }
    }
}
