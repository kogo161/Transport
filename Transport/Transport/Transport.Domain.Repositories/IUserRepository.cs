using System.Collections.Generic;
using Transport.Domain.Models.DbEntities;

namespace Transport.Domain.Repositories
{
    public interface IUserRepository : IGenericRepository<UserEntity>
    {
        IEnumerable<UserEntity> GetUserWithTransport(int id);
    }
}