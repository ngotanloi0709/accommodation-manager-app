using AccommodationManagerApp.Model;
using System;
using System.Xml.Serialization;

namespace AccommodationManagerApp.Util
{
    public static class BillUtils
    {
        public static string ToVietnamese(this Model.BillStatus status)
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
                    return BillStatus.Null;
            }
        }

        public static int TimeToNumber(this string time)
        {
            switch (time)
            {
                case "Lịch Sử": 
                    return 0;       
                case "Tháng Này":
                    return DateTime.Now.Month;
                case "Năm Nay":
                    return DateTime.Now.Year;
                case "Tháng 01":
                    return 1;
                case "Tháng 02":
                    return 2;
                case "Tháng 03":
                    return 3;
                case "Tháng 04":
                    return 4;
                case "Tháng 05":
                    return 5;
                case "Tháng 06":
                    return 6;
                case "Tháng 07":
                    return 7;
                case "Tháng 08":
                    return 8;
                case "Tháng 09":
                    return 9;
                case "Tháng 10":
                    return 10;
                case "Tháng 11":
                    return 11;
                case "Tháng 12":
                    return 12;
                default:
                    throw new ArgumentException("Invalid time format.", nameof(time));
            }
        }
    }
}
