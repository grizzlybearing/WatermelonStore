using API.BusinessLogicLayer.DTO.Product;

namespace API.BusinessLogicLayer.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetAllProductsAsync(CancellationToken cancellationToken = default);
        Task<ProductDTO> GetProductByIdAsync(Guid productId, CancellationToken cancellationToken = default);
        Task<IEnumerable<ProductDTO>> GetProductsByCategoryAsync(Guid categoryId, CancellationToken cancellationToken = default);
        Task<ProductDTO> CreateProductAsync(ProductAddDTO productAddDTO, CancellationToken cancellationToken = default);
        Task UpdateProductAsync(ProductUpdateDTO productUpdateDTO, CancellationToken cancellationToken = default);
        Task DeleteProductAsync(Guid productId, CancellationToken cancellationToken = default);
    }
}
