using Transport.Domain.Models.Requests;
using Transport.Domain.Models.Response;

namespace Transport.Domain.Services
{
    public interface ITransportService
    {
        TransportResponse GetTrasport(int id);
        void AddTransport(TransportRequest request);
        void UpdateTransport(TransportRequest request);
        void Delete(int id);
    }
}