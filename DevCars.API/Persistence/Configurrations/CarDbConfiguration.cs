using DevCars.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevCars.API.Persistence.Configurrations
{
    public class CarDbConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder
                .HasKey(c => c.Id);
            
            // builder
            //     .ToTable("tb_Car");
            
            builder
                .Property(c => c.Brand)
                .IsRequired()
                .HasMaxLength(100);
            builder
                .Property(c => c.ProductionDate)
                .HasDefaultValueSql("now()");
        }
    }
}