using API.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace API.DataAccessLayer.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private ShopdbContext _dbContext;

        public UserRepository(ShopdbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User> Create(User item)
        {
            await _dbContext.AddAsync(item);
            await _dbContext.SaveChangesAsync();
            return item;
        }

        public async Task<int> Delete(int id)
        {
            int res = await _dbContext.Users.Where(u => u.Id == id).ExecuteDeleteAsync();
            await _dbContext.SaveChangesAsync();
            return res;
        }

        public async Task<User?> Get(int id)
        {
            var res = await _dbContext.Users.Where(u => u.Id == id).FirstOrDefaultAsync();
            return res;
        }

        public Task<List<User>> GetAll()
        {
            return _dbContext.Users.ToListAsync();
        }

        public async Task<User?> Update(User item)
        {
            var res = await _dbContext.Users.Where(u => u.Id == item.Id).FirstOrDefaultAsync();
            User u;
            if (res == null)
            {
                return res;
            }
            else
            {
                u = res;
                if (item.Email != null)
                {
                    u.Email = item.Email;
                }
                if (item.Password != null)
                {
                    u.Password = item.Password;
                }
                _dbContext.Update(u);
                await _dbContext.SaveChangesAsync();
                return u;
            }
        }
    }
}
