using AutoMapper;
using API.DataAccessLayer.Models;
using API.BusinessLogicLayer.DTO.Category;
using API.BusinessLogicLayer.DTO.OrderItems;
using API.BusinessLogicLayer.DTO.Orders;
using API.BusinessLogicLayer.DTO.Product;
using API.BusinessLogicLayer.DTO.User;

namespace API.BusinessLogicLayer.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        { 
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<User, UserAddDTO>().ReverseMap();
            CreateMap<User, UserUpdateDTO>().ReverseMap();

            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Product, ProductAddDTO>().ReverseMap();
            CreateMap<Product, ProductUpdateDTO>().ReverseMap();

            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Category, CategoryAddDTO>().ReverseMap();
            CreateMap<Category, CategoryUpdateDTO>().ReverseMap();

            CreateMap<Orders, OrdersDTO>().ReverseMap();
            CreateMap<Orders, OrdersAddDTO>().ReverseMap();
            CreateMap<Orders, OrdersUpdateDTO>().ReverseMap();

            CreateMap<OrderItems, OrderItemsDTO>().ReverseMap();
            CreateMap<OrderItems, OrderItemsAddDTO>().ReverseMap();
            CreateMap<OrderItems, OrderItemsUpdateDTO>().ReverseMap();
        }
    }
}
