using Microsoft.EntityFrameworkCore;
using API.DataAccessLayer;
using API.DataAccessLayer.Interfaces;
using API.DataAccessLayer.Repositories;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDatabaseAndRepositories(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        services.AddDbContext<ShopdbContext>(options =>
            options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 35))));

        services.AddTransient<IUserRepository, UserRepository>();

        return services;
    }
}
