namespace API.DataAccessLayer.Repositories
{
    public interface IProductRepository<Product>
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<IEnumerable<Product>> GetByCategoryAsync(int? category);
        Task<Product> GetbyIdAsync(int? id);
        void CreateAsync(Product? item);
        void UpdateAsync(Product? item);
        void DeleteAsync(int? id);
    }
}
