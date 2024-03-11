using AccommodationManagerApp.Models;

namespace AccommodationManagerApp.Repository {
    public class RoomRepository : Repository<Room> {
        public RoomRepository(AccommodationManagerAppContext context) : base(context)
        {
        }
    }
}