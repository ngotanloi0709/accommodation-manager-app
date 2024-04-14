using AccommodationManagerApp.Model;
using AccommodationManagerApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;


namespace AccommodationManagerApp.Service
{
    public class RequestService
    {
        private readonly RequestRepository _requestRepository;
        
        public RequestService(RequestRepository requestRepository)
        {
            _requestRepository = requestRepository;
        }

        // CRUD Request: Begin

        public void Add(Request request)
        {
            _requestRepository.Add(request);
        }

        public List<Request> GetAll()
        {
            return _requestRepository.GetAll().ToList();
        }

        public Request GetById(int id)
        {
            return _requestRepository.GetById(id);
        }

        public void Update(int id, Request request)
        {
            _requestRepository.Update(id, request);
        }

        public int Delete(int id)
        {
            try
            {
                _requestRepository.Delete(id);
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
        
        public List<Request> GetAllByUserId(int id)
        {
            return _requestRepository.GetAllByUserId(id);
        }

        public List<Request> GetAllWithUser() => _requestRepository.GetAllWithUser();

        public List<Request> GetByCustomizeQuery(List<object> time, RequestStatus status, List<string> text, int? userId) => _requestRepository.GetByCustomizeQuery(time, status, text, userId);
    }
}
