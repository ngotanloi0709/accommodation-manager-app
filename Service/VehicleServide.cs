using AccommodationManagerApp.Model;
using AccommodationManagerApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccommodationManagerApp.Service
{
    public class VehicleService
    {
        private readonly VehicleRepository _vehicleRepository;

        public VehicleService(VehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public List<Vehicle> GetAll()
        {
            return _vehicleRepository.GetAll().ToList();
        }

        public void Add(Vehicle vehicle)
        {
            _vehicleRepository.Add(vehicle);
        }
        public void Update(int id, Vehicle vehicle)
        {
            _vehicleRepository.Update(id, vehicle);
        }

        public bool Delete(int id)
        {
            try
            {
                _vehicleRepository.Delete(id);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public Vehicle GetByNumber(string number)
        {
            return _vehicleRepository.GetByNumber(number);
        }

        public bool IsVehicleNumberExists(string vehicleNumber)
        {
            return _vehicleRepository.GetByNumber(vehicleNumber) != null;
        }
    }
}
