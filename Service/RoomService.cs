using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Properties;
using AccommodationManagerApp.Repository;


namespace AccommodationManagerApp.Service {
    public class RoomService {
        private readonly RoomRepository _roomRepository;
        private readonly ContractRepository _contractRepository;

        public RoomService(RoomRepository roomRepository, ContractRepository contractRepository) {
            _roomRepository = roomRepository;
            _contractRepository = contractRepository;
        }

        public List<Room> GetAll() {
            return _roomRepository.GetAll().ToList();
        }
        
        public List<Room> GetAllWithBuildingAndUserAndContractWithUser() {
            return _roomRepository.GetAllWithBuildingAndUserAndContractWithUser().ToList();
        }

        public List<Room> GetAllWithBuildingId(int buildingId)
        {
            return _roomRepository.GetAllWithBuildingId(buildingId).ToList();
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
            var room = _roomRepository.GetByRoomNumber(roomNumber);

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
                if (contract.EndDate > DateTime.Now && !contract.IsTerminated && contract.User != null) {
                    return string.IsNullOrEmpty(contract.User.Name) ? Resources.NullData : contract.User.Name;
                }
            }
            
            return Resources.NullData; 
        }

        public bool IsExistContract(int roomId) {
            return _contractRepository.GetByRoomId(roomId).Any();
        }

        public bool IsExistById(int? id) {
            return _roomRepository.GetById((int) id) != null;
        }

        public Room GetById(int roomId) {
            return _roomRepository.GetById(roomId);
        }

        public List<Room> GetAllWithNotTerminatedContract() {
            return _roomRepository.GetAllWithNotTerminatedContract().ToList();
        }

        public List<Room> GetByCustomizeQuery(List<Room> rooms, string building, RoomStatus state, List<string> text)
        {
            var filteredRooms = rooms.Where(room =>
                (building == null || room.Building.Name == building) &&
                (state == RoomStatus.Null || room.Status == state) &&
                (text[0] == null) &&
                (text[1] == null || text[1].Equals(room.RoomNumber, StringComparison.OrdinalIgnoreCase))
            );
            return filteredRooms.ToList();
        }
        
        public Contract GetCurrentContract(Room room) {
            if (room.Contracts.Count == 0) {
                return null;
            }
            return room.Contracts.FirstOrDefault(contract => contract.EndDate > DateTime.Now && !contract.IsTerminated && contract.User != null);
        }
    }
}