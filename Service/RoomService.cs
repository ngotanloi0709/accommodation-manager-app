using System;
using System.Collections.Generic;
using System.Linq;
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Properties;
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
        
        public List<Room> GetAllWithBuildingAndContract() {
            return _roomRepository.GetAllWithBuildingAndContract().ToList();
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

        public int? GetIdByRoomNumber(string roomNumber)
        {
            Room room = _roomRepository.GetByRoomNumber(roomNumber);

            if (room != null)
            {
                return room.Id;
            }

            return null;
        }

        public bool IsRoomNumberExists(string roomNumber) {
            return _roomRepository.GetByRoomNumber(roomNumber) != null;
        }
        
        public String GetCurrentTenantName(Room room) {
            if (room.Contracts.Count == 0) {
                return Resources.NullData;
            }

            foreach (var contract in room.Contracts) {
                if (contract.EndDate > DateTime.Now) {
                    return contract.User.Name;
                }
            }
            
            return Resources.NullData; 
        }
    }
}