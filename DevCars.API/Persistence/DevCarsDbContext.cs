using System.Reflection;
using DevCars.API.Entities;
using DevCars.API.Persistence.Configurrations;
using Microsoft.EntityFrameworkCore;

namespace DevCars.API.Persistence
{
    public class DevCarsDbContext : DbContext
    {
        public DevCarsDbContext(DbContextOptions<DevCarsDbContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ExtraOrderItem> ExtraOrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.ApplyConfiguration(new CarDbConfiguration());
            // modelBuilder.ApplyConfiguration(new CustomerDbConfiguration());
            // modelBuilder.ApplyConfiguration(new OrderDbConfiguration());
            // modelBuilder.ApplyConfiguration(new ExtraOrderItemDbConfiguration());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}