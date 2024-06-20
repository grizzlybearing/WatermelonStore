namespace API.DataAccessLayer.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Create(T item);
        Task<T> Update(T item);
        Task<int> Delete(int id);
    }
}
