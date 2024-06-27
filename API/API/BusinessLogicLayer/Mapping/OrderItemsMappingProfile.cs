using AutoMapper;
using API.DataAccessLayer.Models;
using API.BusinessLogicLayer.DTO.OrderItems;

namespace API.BusinessLogicLayer.Mapping
{
    public class OrderItemsMappingProfile : Profile
    {
        public OrderItemsMappingProfile()
        {
            CreateMap<OrderItems, OrderItemsDTO>().ReverseMap();
            CreateMap<OrderItems, OrderItemsAddDTO>().ReverseMap();
            CreateMap<OrderItems, OrderItemsUpdateDTO>().ReverseMap();
        }
    }
}
