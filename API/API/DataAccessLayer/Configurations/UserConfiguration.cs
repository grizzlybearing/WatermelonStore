using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using API.DataAccessLayer.Models;

namespace API.DataAccessLayer.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("tbl_users");

            builder.HasKey(u => u.Id);

            builder.HasIndex(u => u.Email).IsUnique();

            builder.Property(u => u.Id).ValueGeneratedOnAdd()
                .HasColumnName("id");

            builder.Property(u => u.Password)
                .HasMaxLength(30)
                .IsRequired()
                .HasColumnName("password");

            builder.Property(u => u.Email)
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnName("email");
        }
    }
}
