using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using API.DataAccessLayer.Models;

namespace API.DataAccessLayer.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(80);

            builder.Property(u => u.Description)
                .HasMaxLength(100);

            builder.Property(u => u.Price)
                .HasDefaultValue(0.00)
                .HasPrecision(6,2)
                .IsRequired();
        }
    }
}
