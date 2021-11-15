using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Transport.Domain.Models.DbEntities;
using Transport.Domain.Models.Response;
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

        public IEnumerable<UserEntity> GetUserWithTransport(int id)
        {
            var response = _context.User
                .Where(x => x.Id == id)
                .Include(x => x.Transports)
                .ToList();

            return response;
        }
    }
}