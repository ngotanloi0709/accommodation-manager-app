using AccommodationManagerApp.Model;
using System.Linq;

namespace AccommodationManagerApp.Repository
{
    public class ResponseRepository : Repository<Response>
    {
        public ResponseRepository(AccommodationManagerAppContext context) : base(context) { }

        public Response GetResponseByRequestId(int id) => Context.Set<Response>()
                                                                .FirstOrDefault(respone => respone.RequestId == id);

    }
}