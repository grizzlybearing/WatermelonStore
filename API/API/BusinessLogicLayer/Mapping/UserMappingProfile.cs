using AutoMapper;
using API.DataAccessLayer.Models;
using API.BusinessLogicLayer.DTO.User;

namespace API.BusinessLogicLayer.Mapping
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<User, UserAddDTO>().ReverseMap();
            CreateMap<User, UserUpdateDTO>().ReverseMap();
        }
    }
}
