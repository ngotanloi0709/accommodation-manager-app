﻿using System;
using System.Collections.Generic;
using System.Linq;
using AccommodationManagerApp.Forms;
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Repository;

namespace AccommodationManagerApp.Service {
    public class ContractService {
        private readonly ContractRepository _contractRepository;
        private readonly RoomRepository _roomRepository;
        private readonly BillService _billService;

        public ContractService(ContractRepository contractRepository, RoomRepository roomRepository, BillService billService) {
            _contractRepository = contractRepository;
            _roomRepository = roomRepository;
            _billService = billService;
        }

        public List<Contract> GetAllWithUserAndRoom() {
            return _contractRepository.GetAllWithUserAndRoom();
        }

        public List<Contract> GetByRoomIdAndNonExpired(int roomId)
        {
            return _contractRepository.GetByRoomIdAndNonExpired(roomId);
        }

        public void Update(Contract contract) {
            _contractRepository.Update(contract.Id, contract);
        }

        public void TerminateContract(Contract contract) {
            if (!contract.IsTerminated) {
                contract.IsTerminated = true;
                contract.EndDate = DateTime.Now;

                Update(contract);
                _billService.DeleteGeneratedBillsAfterContractTermination(contract);
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

        public Contract GetById(int? id)
        {
            return _contractRepository.GetById(id);
        }

        public bool IsRoomContractsAllExpired(Room room) {
            var result = true;

            if (room.Contracts.Count == 0) return true;
            
            foreach (var contract in room.Contracts) {
                if (!IsContractExpired(contract)) {
                    result = false;
                }
            }

            return result;
        }

        public bool IsRoomAvailableWithToast(int? roomId) {
            var room = _roomRepository.GetByIdWithContract(roomId);

            if (room == null) {
                new ToastForm("Phòng không tồn tại", true).Show();
                return false;
            }

            if (!IsRoomContractsAllExpired(room)) {
                new ToastForm("Hợp đồng của phòng chưa hết hạn", true).Show();
                return false;
            }

            return true;
        }

        public bool IsRoomAvailable(int? roomId) {
            var room = _roomRepository.GetByIdWithContract(roomId);

            if (room == null) {
                return false;
            }

            if (!IsRoomContractsAllExpired(room)) {
                return false;
            }

            return true;
        }

        public List<Room> GetAvailableRooms() {
            var rooms = new List<Room>();

            foreach (var room in _roomRepository.GetAll()) {
                if (IsRoomAvailable(room.Id)) {
                    rooms.Add(room);
                }
            }

            return rooms;
        }

        public void Add(Contract contract) {
            _contractRepository.Add(contract);
        }

        public bool Delete(int contractId) {
            try {
                _contractRepository.Delete(contractId);
                return true;
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }

            return false;
        }

        public List<Contract> GetByUserIdAndNonExpiredWithRoom(int userId) {
            return _contractRepository.GetByUserIdAndNonExpiredWithRoom(userId);
        }

        public List<Contract> GetByCustomizeQuery(List<object> start, List<object> end, List<string> text, bool? terminated)
        => _contractRepository.GetByCustomizeQuery(start, end, text, terminated);
    }
}