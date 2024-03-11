using System.Collections;
using System.Collections.Generic;
using AccommodationManagerApp.Models;
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
            
        }

        public void Update(int id, string name, string building) {
            // _roomRepository.Update(id, new Room { Id = id, Name = name, Building = building });
        }
    }
}