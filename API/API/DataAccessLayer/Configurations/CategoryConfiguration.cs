using API.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace API.DataAccessLayer.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
            public void Configure(EntityTypeBuilder<Category> builder)
            {

                builder.Property(u => u.Name)
                    .HasMaxLength(30)
                    .IsRequired();

            }

    }
}
