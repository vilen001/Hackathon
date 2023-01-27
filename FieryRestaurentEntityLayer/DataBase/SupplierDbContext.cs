

//using FieryRestaurent.Dal.RepositoryImpl;
using FieryRestaurent.Entity.Entity;
using FieryRestaurent.Entity.Enums;
using FieryRestaurent.Entity.Repository;
using Microsoft.EntityFrameworkCore;

namespace FieryRestaurent.Dal.DataBase
{
    public class SupplierDbContext : DbContext
    {
        public SupplierDbContext(DbContextOptions<SupplierDbContext> Options) : base(Options)
        {
        }

        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Buisness> Buisnesses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Address>()
                .Property(s => s.Country)
                .HasConversion(v => v.ToString(),
                v => (Country)Enum.Parse(typeof(Country), v));

            modelBuilder
                .Entity<Address>()
                .Property(s => s.City)
                .HasConversion(v => v.ToString(),
                v => (City)Enum.Parse(typeof(City), v));

            modelBuilder
               .Entity<Address>()
               .Property(s => s.State)
               .HasConversion(v => v.ToString(),
               v => (State)Enum.Parse(typeof(State), v));
        }

    }
}