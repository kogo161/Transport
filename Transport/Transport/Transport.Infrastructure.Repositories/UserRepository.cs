using Transport.Domain.Models.DbEntities;
using Transport.Domain.Repositories;
using Transport.Infrastructure.Store;

namespace Transport.Infrastructure.Repositories
{
    public class UserRepository : GenericRepository<UserEntity>, IUserRepository
    {
        private readonly TransportContext _context;

        public UserRepository(TransportContext context)
            : base(context)
        {
            _context = context;
        }
    }
}