using AutoMapper;
using API.DataAccessLayer.Models;
using API.BusinessLogicLayer.DTO.Product;

namespace API.BusinessLogicLayer.Mapping
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Product, ProductAddDTO>().ReverseMap();
            CreateMap<Product, ProductUpdateDTO>().ReverseMap();
        }
    }
}
