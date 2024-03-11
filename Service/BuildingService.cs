using System.Collections.Generic;
using AccommodationManagerApp.Models;
using AccommodationManagerApp.Repository;

namespace AccommodationManagerApp.Service {
    public class BuildingService {
        private readonly BuildingRepository _buildingRepository;
        
        public BuildingService(BuildingRepository buildingRepository) {
            _buildingRepository = buildingRepository;
        }
        
        public IEnumerable<Building> GetAll() {
            return _buildingRepository.GetAll();
        }
        
        public void Add(Building building) {
            _buildingRepository.Add(building);
        }
        
        public void Update(int id, Building building) {
            _buildingRepository.Update(id, building);
        }
        
        public void Delete(int id) {
            _buildingRepository.Delete(id);
        }
    }
}