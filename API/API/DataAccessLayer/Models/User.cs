﻿namespace API.DataAccessLayer.Models
{
    public class User : BaseModel
    {
        public string Email { get; set; }

        public string PasswordHash { get; set; }
    }
}
