using Transport.Domain.Models.DbEntities;
using Transport.Domain.Models.Requests;
using Transport.Domain.Repositories;
using Transport.Infrastructure.Store;

namespace Transport.Infrastructure.Repositories
{
    public class TransportRepository : GenericRepository<TransportEntity>, ITransportRepository
    {
        private readonly TransportContext _context;

        public TransportRepository(TransportContext context)
            : base(context)
        {
            _context = context;
        }

        public void GetBestCar()
        {
            throw new System.NotImplementedException();
        }
    }
}