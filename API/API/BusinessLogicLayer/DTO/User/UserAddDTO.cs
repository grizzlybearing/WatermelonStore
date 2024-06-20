using System.ComponentModel.DataAnnotations;

namespace API.BusinessLogicLayer.DTO.User
{
    public class UserAddDTO
    {
        [Required]
        public string email { get; set; }
        [Required]
        public string password { get; set; }
    }
}
