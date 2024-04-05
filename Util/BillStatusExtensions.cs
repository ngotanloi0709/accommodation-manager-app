using AccommodationManagerApp.Model;
using System;

namespace AccommodationManagerApp.Util
{
    public static class BillStatusExtensions
    {
        public static string ToVietnamese(this BillStatus category)
        {
            switch (category)
            {
                case BillStatus.Edit:
                    return "Đang Chỉnh Sửa";
                case BillStatus.Unpaid:
                    return "Chưa Thanh Toán";
                case BillStatus.Paid:
                    return "Đã Thanh Toán";
                default:
                    throw new ArgumentOutOfRangeException(nameof(category), category, null);
            }
        }
    }
}
