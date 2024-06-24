using Microsoft.EntityFrameworkCore;
using API.DataAccessLayer;
using API.DataAccessLayer.Interfaces;
using API.DataAccessLayer.Repositories;
using API.BusinessLogicLayer.DTO.User;
using API.BusinessLogicLayer.Validators.User;
using FluentValidation;
using API.BusinessLogicLayer.DTO.Category;
using API.BusinessLogicLayer.Validators.Category;
using API.BusinessLogicLayer.DTO.Product;
using API.BusinessLogicLayer.Validators.Product;
using API.BusinessLogicLayer.DTO.Orders;
using API.BusinessLogicLayer.Validators.Orders;
using API.BusinessLogicLayer.DTO.OrderItems;
using API.BusinessLogicLayer.Validators.OrderItems;

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

        services.AddTransient<ICategoryRepository, CategoryRepository>();
        services.AddTransient<IValidator<CategoryAddDTO>, CategoryAddDTOValidator>();
        services.AddTransient<IValidator<CategoryUpdateDTO>, CategoryUpdateDTOValidator>();
        services.AddTransient<IValidator<CategoryDTO>, CategoryDTOValidator>();

        services.AddTransient<IProductRepository, ProductRepository>();
        services.AddTransient<IValidator<ProductAddDTO>, ProductAddDTOValidator>();
        services.AddTransient<IValidator<ProductUpdateDTO>, ProductUpdateDTOValidator>();
        services.AddTransient<IValidator<ProductDTO>, ProductDTOValidator>();

        services.AddTransient<IOrdersRepository, OrdersRepository>();
        services.AddTransient<IValidator<OrdersAddDTO>, OrdersAddDTOValidator>();
        services.AddTransient<IValidator<OrdersUpdateDTO>, OrdersUpdateDTOValidator>();
        services.AddTransient<IValidator<OrdersUpdateDTO>, OrdersUpdateDTOValidator>();

        services.AddTransient<IOrderItemsRepository, OrderItemsRepository>();
        services.AddTransient<IValidator<OrderItemsAddDTO>, OrderItemsAddDTOValidator>();
        services.AddTransient<IValidator<OrderItemsUpdateDTO>, OrderItemsUpdateDTOValidator>();
        services.AddTransient<IValidator<OrderItemsUpdateDTO>, OrderItemsUpdateDTOValidator>();
        return services;
    }
}
