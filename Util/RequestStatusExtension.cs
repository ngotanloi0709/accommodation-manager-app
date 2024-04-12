using System;
using AccommodationManagerApp.Model;

namespace AccommodationManagerApp.Util
{
    public static class RequestStatusExtension
    {
        public static string ToVietnamese(this RequestStatus category)
        {
            switch (category)
            {
                case RequestStatus.Unsolve:
                    return "Chưa Xử Lý";
                case RequestStatus.Solved:
                    return "Đã Xử Lý";
                default:
                    throw new ArgumentOutOfRangeException(nameof(category), category, null);
            }
        }

        public static RequestStatus ToRequestStatus(this string category)
        {
            switch (category)
            {
                case "Chưa Xử Lý":
                    return RequestStatus.Unsolve;
                case "Đã Xử Lý":
                    return RequestStatus.Solved;
                default:
                    return RequestStatus.Null;
            }
        }
    }
}