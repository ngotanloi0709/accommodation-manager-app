using System;
using System.Collections.Generic;
using AccommodationManagerApp.Forms;
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Repository;

namespace AccommodationManagerApp.Service {
    public class ContractService {
        private readonly ContractRepository _contractRepository;
        private readonly RoomRepository _roomRepository;
        
        public ContractService(ContractRepository contractRepository, RoomRepository roomRepository) {
            _contractRepository = contractRepository;
            _roomRepository = roomRepository;
        }
        
        public List<Contract> GetAllWithUserAndRoom() {
            return _contractRepository.GetAllWithUserAndRoom();
        }

        public void Update(Contract contract) {
            _contractRepository.Update(contract.Id, contract);
        }
        
        public void TerminateContract(Contract contract) {
            if (!contract.IsTerminated) {
                contract.IsTerminated = true;

                Update(contract);
            }
        }
        
        public bool IsContractExpired(Contract contract) {
            if (contract.IsTerminated) {
                return true;
            }

            if (contract.EndDate < DateTime.Now) {
                TerminateContract(contract);
                
                return true;
            }

            return false;
        }
        
        public bool IsRoomContractsAllExpired(Room room) {
            bool result = true;
            
            if (room.Contracts.Count == 0) return true;
            Console.WriteLine(room.Contracts.Count);
            foreach (var contract in room.Contracts) {
                if (!IsContractExpired(contract)) {
                    result = false;
                }
            }

            return result;
        }
        
        public bool IsRoomAvailableWithToast(int? roomId) {
            Room room = _roomRepository.GetByIdWithContract(roomId);
            
            if (room == null) {
                new ToastForm("Phòng không tồn tại", true).Show();
                return false;
            }
            
            if (!IsRoomContractsAllExpired(room)) {
                new ToastForm("Hợp đồng của phòng chưa hết hạn", true).Show();
                return false;
            }
            
            if (room.Status == RoomStatus.Rented) {
                new ToastForm("Trạng thái của phòng đang được thuê", true).Show();
                return false;
            }
            
            return true;
        }

        public void Add(Contract contract) {
            _contractRepository.Add(contract);
        }
    }
}