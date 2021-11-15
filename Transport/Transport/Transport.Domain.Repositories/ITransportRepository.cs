using Transport.Domain.Models.DbEntities;
using Transport.Domain.Models.Requests;

namespace Transport.Domain.Repositories
{
    public interface ITransportRepository : IGenericRepository<TransportEntity>
    {
        public void GetBestCar();
    }
}