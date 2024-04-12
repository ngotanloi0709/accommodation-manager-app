using System;
using System.Linq;
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Repository;
using System.Collections.Generic;
using iTextSharp.text.pdf.parser.clipper;

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

        public List<Bill> GetBillByStatus(BillStatus status) => _billRepository.GetBillByStatus(status);

        public List<Bill> GetAllByUserIdWithContractWithRoomAndUser(int userId) => _billRepository.GetAllByUserIdWithContractWithRoomAndUser(userId);

        public List<Bill> GetByUserIdInThisMonthAnhUnpaid() => _billRepository.GetByUserIdInThisMonthAnhUnpaid();

        public List<Bill> GetAllByContractId(int contractId) => _billRepository.GetAllByContractId(contractId);

        public List<Bill> GetAllBillByUserIdIncludeEdit(int userId) => _billRepository.GetAllBillByUserIdIncludeEdit(userId);

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

        public List<Bill> GetAllWithContractWithRoomAndUser()  => _billRepository.GetAllWithContractWithRoomAndUser().ToList();

        public bool IsBillGenerated(Contract contract) => _billRepository.GetAllByContractId(contract.Id).Count > 0;

        public List<Bill> GetByCustomizeQuery(List<Bill> bills, BillStatus state, List<object> time, List<string> text, int? minPrice, int? maxPrice)
        {
            var filteredBills = bills.Where(bill =>
                (bill.Status == state || state == BillStatus.Null) &&
                (bill.DateOfBill < DateTime.Now || !(bool)time[0]) &&
                (time[1] == null || bill.DateOfBill.Month == (int)time[1]) &&
                (time[2] == null || bill.DateOfBill.Year == (int)time[2]) &&
                (text[0] == null || text[0].Equals(bill.Contract.User.Name, StringComparison.OrdinalIgnoreCase)) &&
                (text[1] == null || text[1].Equals(bill.Contract.Room.RoomNumber, StringComparison.OrdinalIgnoreCase)) &&
                (minPrice == null || bill.RentFee >= minPrice) &&
                (maxPrice == null || bill.RentFee <= maxPrice)
            );
            return filteredBills.ToList();
        }
    }
}