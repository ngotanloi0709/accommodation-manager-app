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
    }
}