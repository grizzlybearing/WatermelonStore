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

        public ShopdbContext(DbContextOptions<ShopdbContext> options, IConfiguration configuration)
            : base(options)
        {
            Database.EnsureCreated();
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 35)));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
