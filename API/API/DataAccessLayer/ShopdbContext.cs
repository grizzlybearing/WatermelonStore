using Microsoft.EntityFrameworkCore;
using API.DataAccessLayer.Models;
using System.Numerics;
using System.Reflection;

namespace API.DataAccessLayer
{

    public class ShopdbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }

        public ShopdbContext(DbContextOptions<ShopdbContext> options, IConfiguration configuration)
            : base(options)
        {
            Database.EnsureCreated();
            _configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}