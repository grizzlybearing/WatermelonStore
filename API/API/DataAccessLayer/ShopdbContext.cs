using Microsoft.EntityFrameworkCore;
using API.DataAccessLayer.Models;
using System.Numerics;
using System.Reflection;

namespace API.DataAccessLayer
{

    public class ShopdbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        string login = "";
        string password = "";

        public ShopdbContext(DbContextOptions<ShopdbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder
            .UseMySql($"host=localhost; database=shopdb; port=3306; username={login}; password={password}", new MySqlServerVersion(new Version(8, 0, 35)));

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Category>().ToTable("Categories");
            modelBuilder.Entity<Category>().Property(p => p.Name).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Category>().HasMany(p => p.Products);
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<Product>().Property(p => p.Name).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Product>().Property(p => p.Description).HasColumnType("varchar");
            modelBuilder.Entity<Product>().Property(p => p.Price).IsRequired().HasPrecision(6, 2);
            modelBuilder.Entity<Product>().Property(p => p.CategoryId).IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}
