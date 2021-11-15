using Microsoft.EntityFrameworkCore;
using Transport.Domain.Models.DbEntities;

namespace Transport.Infrastructure.Store
{
    public class TransportContext : DbContext
    {
        public TransportContext(DbContextOptions<TransportContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>()
                .HasIndex(i => i.PersonalNumber)
                .IsUnique();
        }

        public DbSet<TransportEntity> Transport { get; set; }
        public DbSet<UserEntity> User { get; set; }
    }
}