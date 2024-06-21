using System.ComponentModel.DataAnnotations;

namespace API.BusinessLogicLayer.DTO.User
{
    public class UserDTO
    {
        public Guid id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
