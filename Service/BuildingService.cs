using System;
using System.Collections.Generic;
using System.Linq;
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Repository;

namespace AccommodationManagerApp.Service {
    public class BuildingService {
        private readonly BuildingRepository _buildingRepository;
        private readonly RoomService _roomService;
        
        public BuildingService(BuildingRepository buildingRepository, RoomService roomService) {
            _buildingRepository = buildingRepository;
            _roomService = roomService;
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
                var rooms = _roomService.GetByBuildingId(id);
                foreach (var room in rooms)
                {
                    room.BuildingId = null;
                    _roomService.Update(room.Id, room);
                }

                _buildingRepository.Delete(id);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false; 
            }
        }

        public Building GetById(int id) {
            return _buildingRepository.GetById(id);
        }
    }
}