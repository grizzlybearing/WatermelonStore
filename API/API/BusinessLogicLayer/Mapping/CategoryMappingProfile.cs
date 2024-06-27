using AutoMapper;
using API.DataAccessLayer.Models;
using API.BusinessLogicLayer.DTO.Category;

namespace API.BusinessLogicLayer.Mapping
{
    public class CategoryMappingProfile : Profile
    {
        public CategoryMappingProfile()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Category, CategoryAddDTO>().ReverseMap();
            CreateMap<Category, CategoryUpdateDTO>().ReverseMap();
        }
    }
}
