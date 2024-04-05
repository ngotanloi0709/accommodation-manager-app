using System;
using System.Linq;
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Repository;
using System.Collections.Generic;

namespace AccommodationManagerApp.Service {
    public class BillService {
        private readonly BillRepository _billRepository;
        private readonly FixedPriceRepository _fixedPriceRepository;

        public BillService(BillRepository billRepository, FixedPriceRepository fixedPriceRepository) {
            _billRepository = billRepository;
            _fixedPriceRepository = fixedPriceRepository;
        }

        public void Add(Bill bill) => _billRepository.Add(bill);

        public List<Bill> GetAll() => _billRepository.GetAll().ToList();

        public void Update(int id, Bill bill) => _billRepository.Update(id, bill);

        public int Delete(int id) {
            try {
                _billRepository.Delete(id);
                return 1;
            }
            catch (ArgumentNullException) {
                return 0;
            }
            catch (Exception) {
                return -1;
            }
        }

        public List<Bill> GetAllByUserId(int userId) => _billRepository.GetAllBillByUserId(userId);

        public List<Bill> GetByUserIdInThisMonthAnhUnpaid() => _billRepository.GetByUserIdInThisMonthAnhUnpaid();

        public List<Bill> GetBillUnpaidByMonthAndYear(int month, int year) => _billRepository.GetBillUnpaidByMonthAndYear(month, year);

        public List<Bill> GetBillPaidByMonthAndYear(int month, int year) => _billRepository.GetBillPaidByMonthAndYear(month, year);

        public List<Bill> GetBillIsUpdatedByMonthAndYear(int month, int year) => _billRepository.GetBillIsUpdatedByMonthAndYear(month, year);

        public FixedPrice GetWaterPrice() => _fixedPriceRepository.GetWaterPrice();

        public FixedPrice GetElectricityPrice() => _fixedPriceRepository.GetElectricityPrice();

        public FixedPrice GetInternetPrice() => _fixedPriceRepository.GetInternetPrice();

        public void UpdateFixedPrice(int water, int electricity, int internet) {
            var waterPrice = GetWaterPrice();
            waterPrice.Price = water;
            _fixedPriceRepository.Update(waterPrice.Id, waterPrice);

            var electricityPrice = GetElectricityPrice();
            electricityPrice.Price = electricity;
            _fixedPriceRepository.Update(electricityPrice.Id, electricityPrice);

            var internetPrice = GetInternetPrice();
            internetPrice.Price = internet;
            _fixedPriceRepository.Update(internetPrice.Id, internetPrice);
        }

        public void GenerateMissingBillsForContract(Contract contract) {
            var current = contract.StartDate;
            
            int water = GetWaterPrice().Price;
            int electricity = GetElectricityPrice().Price;
            int internet = GetInternetPrice().Price;
            
            var bills = _billRepository.GetAllByContractId(contract.Id).ToList();
            
            while (current < contract.EndDate) {
                var existingBill = bills.FirstOrDefault(bill => bill.DateOfBill.Month == current.Month && bill.DateOfBill.Year == current.Year);
                if (existingBill == null) {
                    var bill = new Bill(contract.UserId, contract.Id, current);
                    bill.RentFee = contract.Price;
                    
                    if (current.Month == DateTime.Now.Month) {
                        bill.WaterFee = water;
                        bill.ElectricityFee = electricity;
                        bill.InternetFee = internet;
                    }
            
                    Add(bill);
                }
            
                current = current.AddMonths(1);
            }
        }

        public void DeleteGeneratedBillsAfterContractTermination(Contract contract) {
            var bills = _billRepository.GetAllByContractId(contract.Id);
            foreach (var bill in bills.Where(bill => bill.DateOfBill > contract.EndDate)) {
                _billRepository.Delete(bill.Id);
            }
        }

        public List<Bill> GetAllWithContractWithRoomAndUser() {
            return _billRepository.GetAllWithContractWithRoomAndUser().ToList();
        }

        public bool IsBillGenerated(Contract contract) {
            return _billRepository.GetAllByContractId(contract.Id).Count > 0;
        }
    }
}