using Microsoft.EntityFrameworkCore;
using API.DataAccessLayer;
using API.DataAccessLayer.Interfaces;
using API.DataAccessLayer.Repositories;
using API.BusinessLogicLayer.DTO.User;
using API.BusinessLogicLayer.Validators.User;
using FluentValidation;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDatabaseAndRepositories(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        services.AddDbContext<ShopdbContext>(options =>
            options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 35))));

        services.AddTransient<IUserRepository, UserRepository>();
        services.AddTransient<IValidator<UserAddDTO>, UserAddDTOValidator>();
        services.AddTransient<IValidator<UserUpdateDTO>, UserUpdateDTOValidator>();
        services.AddTransient<IValidator<UserDTO>, UserDTOValidator>();

        return services;
    }
}
