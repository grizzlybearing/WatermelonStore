using API.DataAccessLayer.Models;

namespace API.DataAccessLayer.Interfaces
{
    public interface IProductRepository: IBaseRespository<Product>
    {
        Task<List<Product>> GetByCategoryAsync(Guid id, CancellationToken cancellationToken = default);
    }
}
