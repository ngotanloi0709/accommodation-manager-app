using AccommodationManagerApp.Model;
using AccommodationManagerApp.Service;

namespace AccommodationManagerApp.Forms
{
    public partial class PreviewResponseForm : BaseForm
    {
        private readonly Response _response;
        private readonly ResponseService _responseService;
        
        public PreviewResponseForm(Request request)
        {
            InitializeComponent();
            
            _responseService = ServiceLocator.ServiceProvider.GetService(typeof(ResponseService)) as ResponseService;
            _response = _responseService.GetResponseByRequestId(request.Id);
            
            SetUpRequestForm();
        }

        private void SetUpRequestForm()
        {

            labelRequestUser.Text = "Đỗ Trần Long Nhân";
            labelRequestDate.Text = _response.CreatedAt.ToString("dd/MM/yyyy");
            textBoxDesRequest.Text = _response.Des;
        }
    }
}
