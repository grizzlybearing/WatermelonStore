using AutoMapper;
using API.DataAccessLayer.Models;
using API.BusinessLogicLayer.DTO.Orders;

namespace API.BusinessLogicLayer.Mapping
{
    public class OrdersMappingProfile : Profile
    {
        public OrdersMappingProfile()
        {
            CreateMap<Orders, OrdersDTO>().ReverseMap();
            CreateMap<Orders, OrdersAddDTO>().ReverseMap();
            CreateMap<Orders, OrdersUpdateDTO>().ReverseMap();
        }
    }
}
