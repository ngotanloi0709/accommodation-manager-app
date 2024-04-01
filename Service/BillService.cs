using AccommodationManagerApp.Model;
using AccommodationManagerApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public void Add(Bill bill)
        {
            _billRepository.Add(bill);
        }

        public List<Bill> GetAll()
        {
            return _billRepository.GetAll().ToList();
        }

        public Bill GetById(int id)
        {
            return _billRepository.GetById(id);
        }

        public void Update(int id, Bill bill)
        {
            _billRepository.Update(id, bill);
        }
        
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
            } catch (Exception)
            { 
                return -1;
            }
        }

        public FixedPrice GetWaterPrice() {
            return _fixedPriceRepository.GetWaterPrice();
        }

        public FixedPrice GetElectricityPrice() {
            return _fixedPriceRepository.GetElectricityPrice();
        }

        public FixedPrice GetInternetPrice() {
            return _fixedPriceRepository.GetInternetPrice();
        }

        public void UpdateFixedPrice(int water, int electricity, int internet) {
            FixedPrice waterPrice = GetWaterPrice();
            waterPrice.Price = water;
            _fixedPriceRepository.Update(waterPrice.Id, waterPrice);

            FixedPrice electricityPrice = GetElectricityPrice();
            electricityPrice.Price = electricity;
            _fixedPriceRepository.Update(electricityPrice.Id, electricityPrice);

            FixedPrice internetPrice = GetInternetPrice();
            internetPrice.Price = internet;
            _fixedPriceRepository.Update(internetPrice.Id, internetPrice);
        }
    }
}
