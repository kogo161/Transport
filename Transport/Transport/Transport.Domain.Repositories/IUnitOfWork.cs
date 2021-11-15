using Transport.Domain.Models.Response;

namespace Transport.Domain.Repositories
{
    public interface IUnitOfWork
    {
        ITransportRepository Transport { get; }
        IUserRepository User { get; }
        void Save();
        void Dispose();
    }
}