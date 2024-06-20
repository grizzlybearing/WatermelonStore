using System.ComponentModel.DataAnnotations;

namespace API.BusinessLogicLayer.DTO.User
{
    public class UserDTO
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string password { get; set; }
    }
}
