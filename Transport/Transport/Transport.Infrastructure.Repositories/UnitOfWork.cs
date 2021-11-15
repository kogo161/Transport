using System;
using Transport.Domain.Models.DbEntities;
using Transport.Domain.Models.Response;
using Transport.Domain.Repositories;
using Transport.Infrastructure.Store;

namespace Transport.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly TransportContext _context;
        private GenericRepository<TransportEntity> _transportRepository;
        public ITransportRepository Transport { get; }
        public IUserRepository User { get; }
        private bool _disposed = false;

        public UnitOfWork(TransportContext context)
        {
            _context = context;
            Transport = new TransportRepository(_context);
            User = new UserRepository(_context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}