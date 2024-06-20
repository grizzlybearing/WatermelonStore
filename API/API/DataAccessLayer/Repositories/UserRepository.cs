using API.DataAccessLayer.Models;

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
            throw new NotImplementedException();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<User> Update(User item)
        {
            throw new NotImplementedException();
        }
    }
}
