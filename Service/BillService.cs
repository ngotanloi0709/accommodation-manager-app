using AccommodationManagerApp.Model;
using AccommodationManagerApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccommodationManagerApp.Service
{
    public class BillService
    {
        private readonly BillRepository _billRepository;

        public BillService(BillRepository billRepository)
        {
            _billRepository = billRepository;
        }

        // CRUD Bill: Begin

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

        public void DeleteAll()
        {
            _billRepository.DeleteAll();
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
        
        // CRUD Bill: end
        
    }
}
