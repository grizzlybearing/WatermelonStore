using Microsoft.EntityFrameworkCore;
using API.DataAccessLayer.Models;
using System.Numerics;
using System.Reflection;

namespace API.DataAccessLayer
{

    public class ShopdbContext : DbContext
    {
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
            base.OnModelCreating(modelBuilder);
        }
    }
}
