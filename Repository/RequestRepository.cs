using AccommodationManagerApp.Model;
using System.Collections.Generic;
using System.Linq;

namespace AccommodationManagerApp.Repository
{
    public class RequestRepository : Repository<Request>
    {
        public RequestRepository(AccommodationManagerAppContext context) : base(context) { }
        public List<Request> GetAllByUserId(int id)
        {
            return Context.Set<Request>().Where(u => u.UserId == id).ToList();
        }

        public List<Request> GetAllWithUser() => Context.Set<Request>().Include("User").ToList();
    }
}
