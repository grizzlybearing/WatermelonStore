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

        public User Create(User item)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User Update(User item)
        {
            throw new NotImplementedException();
        }
    }
}
