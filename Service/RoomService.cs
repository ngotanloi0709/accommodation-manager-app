using System.Collections;
using System.Collections.Generic;
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Repository;


namespace AccommodationManagerApp.Service {
    public class RoomService {
        private readonly RoomRepository _roomRepository;

        public RoomService(RoomRepository roomRepository) {
            _roomRepository = roomRepository;
        }

        public IEnumerable<Room> GetAll() {
            return _roomRepository.GetAll();
        }

        public void Delete(int id) {
            _roomRepository.Delete(id);
        }

        public void Add(Room room) {
            _roomRepository.Add(room);
        }

        public void Update(int id, Room room) {
            _roomRepository.Update(id, room);
        }

        public Room GetById(int id) {
            return _roomRepository.GetById(id);
        }
        
        public Room GetByIdWithBuilding(int id) {
            return _roomRepository.GetByIdWithBuilding(id);
        }
        
        public IEnumerable<Room> GetAllWithBuilding() {
            return _roomRepository.GetAllWithBuilding();
        }
        
        public IEnumerable<Room> GetAllByBuildingId(int buildingId) {
            return _roomRepository.GetAllByBuildingId(buildingId);
        }
    }
}