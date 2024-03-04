using AccommodationManagerApp.Util;

namespace AccommodationManagerApp.Repository {
    public class InitLogRepository : Repository<InitLog> {
        public InitLogRepository(AccommodationManagerAppContext context) : base(context)
        {
        }
    }
}