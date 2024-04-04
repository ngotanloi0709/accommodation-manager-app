using AccommodationManagerApp.Model;

namespace AccommodationManagerApp.Repository
{
    public class ResponseRepository : Repository<Response>
    {
        public ResponseRepository(AccommodationManagerAppContext context) : base(context) { }
    }
}