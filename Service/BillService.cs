using System;
using System.Linq;
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Repository;
using System.Collections.Generic;

namespace AccommodationManagerApp.Service
{
    public class BillService
    {
        private readonly BillRepository _billRepository;
        private readonly FixedPriceRepository _fixedPriceRepository;
        public BillService(BillRepository billRepository, FixedPriceRepository fixedPriceRepository)
        {
            _billRepository = billRepository;
            _fixedPriceRepository = fixedPriceRepository;
        }

        public void Add(Bill bill) => _billRepository.Add(bill);

        public List<Bill> GetAll() => _billRepository.GetAll().ToList();

        public Bill GetById(int id) => _billRepository.GetById(id);

        public void Update(int id, Bill bill) => _billRepository.Update(id, bill);

        public int Delete(int id)
        {
            try
            {
                _billRepository.Delete(id);
                return 1;
            }
            catch (ArgumentNullException)
            {
                return 0;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public List<Bill> GetAllBillByUserId(int userId) => _billRepository.GetAllBillByUserId(userId);

        public FixedPrice GetWaterPrice() => _fixedPriceRepository.GetWaterPrice();

        public FixedPrice GetElectricityPrice() => _fixedPriceRepository.GetElectricityPrice();

        public FixedPrice GetInternetPrice() => _fixedPriceRepository.GetInternetPrice();

        public void UpdateFixedPrice(int water, int electricity, int internet)
        {
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

        public bool IsFee(Bill bill) => bill.ElecFee == 0 || bill.InternetFee == 0 || bill.WaterFee == 0;

        public bool IsQty(Bill bill) => bill.ElecQuantity == 0 || bill.WaterQuantity == 0;

        public void GenerateBillByContract(Contract contract)
        {
            var current = contract.StartDate;
            while (current < contract.EndDate)
            {
                var bill = new Bill(contract.UserId, contract.Id, current);
                if (current.Month == contract.StartDate.Month)
                {
                    bill.WaterFee = GetWaterPrice().Price;
                    bill.ElecFee = GetElectricityPrice().Price;
                    bill.InternetFee = GetInternetPrice().Price;
                }
                Add(bill);
                current = current.AddMonths(1);
            }
        }
    }
}
