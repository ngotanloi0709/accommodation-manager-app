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
    }
}
