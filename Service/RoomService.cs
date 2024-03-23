using System;
using System.Collections.Generic;
using System.Linq;
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Repository;


namespace AccommodationManagerApp.Service {
    public class RoomService {
        private readonly RoomRepository _roomRepository;

        public RoomService(RoomRepository roomRepository) {
            _roomRepository = roomRepository;
        }

        public List<Room> GetAll() {
            return _roomRepository.GetAll().ToList();
        }
        
        public List<Room> GetAllWithBuildingAndUser() {
            return _roomRepository.GetAllWithBuildingAndUser().ToList();
        }

        public bool Delete(int id) {
            try
            {
                _roomRepository.Delete(id);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
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
        
        public List<Room> GetAllWithBuilding() {
            return _roomRepository.GetAllWithBuilding().ToList();
        }
        
        public List<Room> GetAllByBuildingId(int buildingId) {
            return _roomRepository.GetAllByBuildingId(buildingId).ToList();
        }

        public Room GetByRoomNumber(string roomNumber)
        {
            return _roomRepository.GetByRoomNumber(roomNumber);
        }

        public int? GetIdByRoomNumber(string roomNumber)
        {
            Room room = _roomRepository.GetByRoomNumber(roomNumber);

            if (room != null)
            {
                return room.Id;
            }

            return null;
        }
        
        public List<Room> GetByBuildingId(int buildingId) {
            return _roomRepository.GetAll().Where(room => room.BuildingId == buildingId).ToList();
        }

        public bool IsRoomNumberExists(string roomNumber) {
            return _roomRepository.GetByRoomNumber(roomNumber) != null;
        }
    }
}