﻿using AccommodationManagerApp.Model;
using System;
using System.Collections.Generic;

namespace AccommodationManagerApp.Util
{
    public static class BillUtils
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
                    throw new ArgumentException("Invalid status format.", nameof(status));
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
                case "Tất Cả":
                    return -1;
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
        
        public static List<object> ChangeTextToDate(this string text)
        {
            int router = TimeToNumber(text);
            if (router == -1) return new List<object>() { false, null, null };
            if (router == 0) return new List<object>() { true, null, null};
            if (router <= 12) return new List<object>() { false, router, null };
            return new List<object>() { true, null, router };
        }

        public static bool CheckMinMaxPrice(int? min, int? max)
        {
            if (min != null && max != null && min > max) return false;
            return true;
        }
        
        public static List<string> ChangeSearchInput(string selection, string input)
        {
            if (input == "") return new List<string>(){ null, null};
            if (selection.Equals("Tên Người")) return new List<string>() { input, null};
            if (selection.Equals("Số Phòng")) return new List<string>() { null, input};
            return null;
        }
    }
}
