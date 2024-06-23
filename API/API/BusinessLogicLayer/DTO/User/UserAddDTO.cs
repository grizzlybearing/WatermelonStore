using System.ComponentModel.DataAnnotations;

namespace API.BusinessLogicLayer.DTO.User
{
    public class UserAddDTO
    {
        public string email { get; set; }
        public string password { get; set; }
    }
}
