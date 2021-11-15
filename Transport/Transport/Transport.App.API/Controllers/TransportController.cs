using Microsoft.AspNetCore.Mvc;
using Transport.Domain.Models.Requests;
using Transport.Domain.Models.Response;
using Transport.Domain.Services;

namespace Transport.App.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransportController : ControllerBase
    {
        private readonly ITransportService _transportService;

        public TransportController(ITransportService transportService)
        {
            _transportService = transportService;
        }

        [HttpGet]
        public TransportResponse GetTransport(int id)
        {
            var res = _transportService.GetTrasport(id);
            return res;
        }

        [HttpPut]
        public void TransportUpdate(TransportRequest request)
        {
            _transportService.UpdateTransport(request);
        }

        [HttpPost]
        public void AddTransport(TransportRequest request)
        {
            _transportService.AddTransport(request);
        }

        [HttpDelete]
        public void DeleteTrasport(int id)
        {
            _transportService.Delete(id);
        }
    }
}