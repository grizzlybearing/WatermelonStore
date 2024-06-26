using AutoMapper;
using API.BusinessLogicLayer.DTO.Product;
using API.BusinessLogicLayer.Interfaces;
using API.DataAccessLayer.Interfaces;
using API.DataAccessLayer.Models;

namespace BLL.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDTO>> GetAllProductsAsync(CancellationToken cancellationToken = default)
        {
            var products = await _productRepository.GetAllAsync(cancellationToken);
            return _mapper.Map<IEnumerable<ProductDTO>>(products);
        }

        public async Task<ProductDTO> GetProductByIdAsync(Guid productId, CancellationToken cancellationToken = default)
        {
            var product = await _productRepository.GetAsync(productId, cancellationToken);
            return _mapper.Map<ProductDTO>(product);
        }

        public async Task<IEnumerable<ProductDTO>> GetProductsByCategoryAsync(Guid categoryId, CancellationToken cancellationToken = default)
        {
            var products = await _productRepository.GetByCategoryAsync(categoryId, cancellationToken);
            return _mapper.Map<IEnumerable<ProductDTO>>(products);
        }

        public async Task<ProductDTO> CreateProductAsync(ProductAddDTO productAddDTO, CancellationToken cancellationToken = default)
        {
            var product = _mapper.Map<Product>(productAddDTO);
            await _productRepository.CreateAsync(product, cancellationToken);
            return _mapper.Map<ProductDTO>(product);
        }

        public async Task UpdateProductAsync(ProductUpdateDTO productUpdateDTO, CancellationToken cancellationToken = default)
        {
            var product = _mapper.Map<Product>(productUpdateDTO);
            await _productRepository.UpdateAsync(product, cancellationToken);
        }

        public async Task DeleteProductAsync(Guid productId, CancellationToken cancellationToken = default)
        {
            await _productRepository.DeleteAsync(productId, cancellationToken);
        }
    }
}