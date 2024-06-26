using API.BusinessLogicLayer.DTO.Category;

namespace API.BusinessLogicLayer.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDTO>> GetAllCategoriesAsync(CancellationToken cancellationToken = default);
        Task<CategoryDTO> GetCategoryByIdAsync(Guid categoryId, CancellationToken cancellationToken = default);
        Task<CategoryDTO> CreateCategoryAsync(CategoryAddDTO categoryAddDTO, CancellationToken cancellationToken = default);
        Task UpdateCategoryAsync(CategoryUpdateDTO categoryUpdateDTO, CancellationToken cancellationToken = default);
        Task DeleteCategoryAsync(Guid categoryId, CancellationToken cancellationToken = default);
    }
}
