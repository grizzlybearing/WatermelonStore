namespace API.DataAccessLayer.Repositories
{
    public interface IProductRepository<Product>
    {
        List<Product> GetAll();
        IQueryable<Product> GetByCategory(int? category);
        Product GetbyId(int? id);
        void CreateAsync(Product? item);
        void UpdateAsync(Product? item);
        void DeleteAsync(int? id);
    }
}
