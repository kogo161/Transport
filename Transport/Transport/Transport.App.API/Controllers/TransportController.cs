using System;
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
            try
            {
                var res = _transportService.GetTrasport(id);
                return res;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPut]
        public void TransportUpdate(TransportRequest request)
        {
            try
            {
                _transportService.UpdateTransport(request);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPost]
        public void AddTransport(TransportRequest request)
        {
            try
            {
                _transportService.AddTransport(request);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpDelete]
        public void DeleteTrasport(int id)
        {
            try
            {
                _transportService.Delete(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}