namespace API.BusinessLogicLayer.DTO.User
{
    public class UserUpdateDTO
    {
        public int id { get; set; }
        public string? email { get; set; } = null;
        public string? password { get; set; } = null;
    }
}
