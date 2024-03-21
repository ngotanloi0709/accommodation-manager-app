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
        public VehicleRepository(AccommodationManagerAppContext context) : base(context)
        {
        }

        public Vehicle GetByNumber(string number)
        {
            return Context.Set<Vehicle>().FirstOrDefault(v => v.number == number);
        }
        public Vehicle GetByIdWithRoom(int id)
        {
            return Context.Set<Vehicle>().Include("Room").FirstOrDefault(v => v.Id == id);
        }
        public List<Vehicle> GetAllWithRoom()
        {
            return Context.Set<Vehicle>().Include("Room").ToList();
        }
        public List<Vehicle> GetAllByRoomId(int roomId)
        {
            return Context.Set<Vehicle>().Where(v => v.RoomId == roomId).ToList();
        }
    }
}
