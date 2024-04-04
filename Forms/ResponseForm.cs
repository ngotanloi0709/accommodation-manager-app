using AccommodationManagerApp.Model;
using AccommodationManagerApp.Service;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms
{
    public partial class ResponseForm : BaseForm
    {
        private readonly Request _request;
        private readonly RequestService _requestService;
        private readonly ResponseService _responseService;


        public ResponseForm(Request request)
        {
            _request = request;
            _requestService = ServiceLocator.ServiceProvider.GetService(typeof(RequestService)) as RequestService;
            _responseService = ServiceLocator.ServiceProvider.GetService(typeof(ResponseService)) as ResponseService;
            InitializeComponent();
        }
    }
}
