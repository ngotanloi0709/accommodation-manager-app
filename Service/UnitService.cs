using System.Collections;
using System.Collections.Generic;
using AccommodationManagerApp.Models;
using AccommodationManagerApp.Repository;


namespace AccommodationManagerApp.Service {
    public class UnitService {
        private readonly UnitRepository _unitRepository;

        public UnitService(UnitRepository unitRepository) {
            _unitRepository = unitRepository;
        }

        public IEnumerable<Unit> GetAll() {
            return _unitRepository.GetAll();
        }

        public void Delete(int id) {
            _unitRepository.Delete(id);
        }

        public void Add(string name, string building) {
            _unitRepository.Add(new Unit { Name = name, Building = building });
        }

        public void Update(int id, string name, string building) {
            _unitRepository.Update(id, new Unit { Id = id, Name = name, Building = building });
        }
    }
}