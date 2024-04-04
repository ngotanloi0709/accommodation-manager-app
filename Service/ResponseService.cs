using System;
using System.Collections.Generic;
using System.Linq;
using AccommodationManagerApp.Model;
using AccommodationManagerApp.Repository;

namespace AccommodationManagerApp.Service
{
    public class ResponseService
    {
        private readonly ResponseRepository _responseRepository;
        
        public ResponseService(ResponseRepository responseRepository)
        {
            _responseRepository = responseRepository;
        }
        
        // CRUD Response: Begin

        public void Add(Response response)
        {
            _responseRepository.Add(response);
        }
        
        public List<Response> GetAll()
        {
            return _responseRepository.GetAll().ToList();
        }

        public Response GetById(int id)
        {
            return _responseRepository.GetById(id);
        }

        public void Update(int id, Response response)
        {
            _responseRepository.Update(id, response);
        }
        
        public bool Delete(int resId) {
            try {
                _responseRepository.Delete(resId);
                return true;
            }
            catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }
        }
    }
}