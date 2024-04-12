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

        public List<Request> GetByCustomizeQuery(List<Request> requests, List<object> time, RequestStatus status, List<string> text)
        {
            var filteredRequests = requests.Where(request =>
                (time[0] == null || request.CreatedAt < DateTime.Now) &&
                (time[1] == null || request.CreatedAt.Month == (int)time[1]) &&
                (time[2] == null || request.CreatedAt.Year == (int)time[2]) &&
                (status == RequestStatus.Null || request.Status == status) &&
                (text[0] == null || text[0].Equals(request.User.Name, StringComparison.OrdinalIgnoreCase)) &&
                (text[1] == null) 
            );
            return filteredRequests.ToList();
        }
    }
}
