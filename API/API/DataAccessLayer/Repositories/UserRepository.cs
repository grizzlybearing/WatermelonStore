using API.DataAccessLayer.Interfaces;
using API.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace API.DataAccessLayer.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository 
    {
        private ShopdbContext _context;

        public UserRepository(ShopdbContext context) : base(context)
        {
            _context = context;
        }
    }
}
