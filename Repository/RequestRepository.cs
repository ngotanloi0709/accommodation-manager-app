using AccommodationManagerApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AccommodationManagerApp.Repository
{
    public class RequestRepository : Repository<Request>
    {
        public RequestRepository(AccommodationManagerAppContext context) : base(context) { }
        public List<Request> GetAllByUserId(int id) => Context.Set<Request>().Include("User").Where(user => user.UserId == id).ToList();
        public List<Request> GetAllWithUser() => Context.Set<Request>().Include("User").ToList();
    
        public List<Request> GetByCustomizeQuery(List<object> time, RequestStatus status, List<string> text)
        {
            var time0 = time[0] as DateTime?;
            var time1 = time[1] as int?;
            var time2 = time[2] as int?;
            var text0 = text[0];
            var text1 = text[1];

            var filteredRequests = Context.Set<Request>().AsNoTracking()
                .Include("User")
                .Where(request =>
                (time0 == null || request.CreatedAt < time0) &&
                (time1 == null || request.CreatedAt.Month == time1) &&
                (time2 == null || request.CreatedAt.Year == time2) &&
                (status == RequestStatus.Null || request.Status == status) &&
                (text0 == null || text0.Equals(request.User.Name, StringComparison.OrdinalIgnoreCase)) &&
                (text1 == null)
            );
            return filteredRequests.ToList();
        }
    }
}
