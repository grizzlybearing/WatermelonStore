﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
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

            builder.Property(u => u.Id)
                .HasColumnName("id");

            builder.Property(u => u.PasswordHash)
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnName("password_hash");

            builder.Property(u => u.Email)
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnName("email");
        }
    }
}