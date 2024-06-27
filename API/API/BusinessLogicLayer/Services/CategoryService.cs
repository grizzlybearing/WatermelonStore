using AutoMapper;
using API.BusinessLogicLayer.DTO.Category;
using API.BusinessLogicLayer.Interfaces;
using API.DataAccessLayer.Interfaces;
using API.DataAccessLayer.Models;

namespace BLL.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CategoryDTO>> GetAllCategoriesAsync(CancellationToken cancellationToken = default)
        {
            var categories = await _categoryRepository.GetAllAsync(cancellationToken);
            return _mapper.Map<IEnumerable<CategoryDTO>>(categories);
        }

        public async Task<CategoryDTO> GetCategoryByIdAsync(Guid categoryId, CancellationToken cancellationToken = default)
        {
            var category = await _categoryRepository.GetAsync(categoryId, cancellationToken);
            return _mapper.Map<CategoryDTO>(category);
        }

        public async Task<CategoryDTO> CreateCategoryAsync(CategoryAddDTO categoryAddDTO, CancellationToken cancellationToken = default)
        {
            var category = _mapper.Map<Category>(categoryAddDTO);
            await _categoryRepository.CreateAsync(category, cancellationToken);
            return _mapper.Map<CategoryDTO>(category);
        }

        public async Task UpdateCategoryAsync(CategoryUpdateDTO categoryUpdateDTO, CancellationToken cancellationToken = default)
        {
            var category = _mapper.Map<Category>(categoryUpdateDTO);
            await _categoryRepository.UpdateAsync(category, cancellationToken);
        }

        public async Task DeleteCategoryAsync(Guid categoryId, CancellationToken cancellationToken = default)
        {
            await _categoryRepository.DeleteAsync(categoryId, cancellationToken);
        }
    }
}
