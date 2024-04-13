using AccommodationManagerApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccommodationManagerApp.Repository
{
    public class VehicleRepository : Repository<Vehicle>
    {
        public VehicleRepository(AccommodationManagerAppContext context) : base(context) { }

        public Vehicle GetByNumber(string number)
        {
            return Context.Set<Vehicle>().FirstOrDefault(v => v.Number == number);
        }
        public Vehicle GetByIdWithRoom(int id)
        {
            return Context.Set<Vehicle>().Include("Room").FirstOrDefault(v => v.Id == id);
        }
        public List<Vehicle> GetAllWithRoom()
        => Context.Set<Vehicle>().Include("Room").ToList();

        public List<Vehicle> GetAllByRoomId(int roomId)
        => Context.Set<Vehicle>().Where(v => v.RoomId == roomId).ToList();

        public List<Vehicle> GetByCustomizeQuery(VehicleCategory type, List<string> text)
        {
            var name = text[0];
            var roomNumber = text[1];
            var number = text[2];

            var filteredVehicles = Context.Set<Vehicle>()
                .Include("Room")
                .Where(vehicle =>
                (vehicle.Category == type || type == VehicleCategory.Null) &&
                (name == null || name.Equals(vehicle.Name, StringComparison.OrdinalIgnoreCase)) &&
                (roomNumber == null || roomNumber.Equals(vehicle.Room.RoomNumber, StringComparison.OrdinalIgnoreCase)) &&
                (number == null || number.Equals(vehicle.Number, StringComparison.OrdinalIgnoreCase))
            );
            return filteredVehicles.ToList();

        }
    }
}
