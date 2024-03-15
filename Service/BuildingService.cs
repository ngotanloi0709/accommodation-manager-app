using System;
using System.Collections.Generic;
using System.Linq;
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Repository;

namespace AccommodationManagerApp.Service {
    public class BuildingService {
        private readonly BuildingRepository _buildingRepository;
        
        public BuildingService(BuildingRepository buildingRepository) {
            _buildingRepository = buildingRepository;
        }
        
        public List<Building> GetAll() {
            return _buildingRepository.GetAll().ToList();
        }
        
        public void Add(Building building) {
            _buildingRepository.Add(building);
        }
        
        public void Update(int id, Building building) {
            _buildingRepository.Update(id, building);
        }
        
        public bool Delete(int id) {
            try
            {
                _buildingRepository.Delete(id);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public int? GetIdByName(string name) {
            Building building = _buildingRepository.GetByName(name);
            
            if (building != null) {
                return building.Id;
            }
            
            return null;
        }

        public bool IsBuildingNameExists(string buildingName) {
            return _buildingRepository.GetByName(buildingName) != null;
        }
    }
}