using API.DataAccessLayer.Models;

namespace API.DataAccessLayer.Repositories
{
    public interface ICategoryRepository<Category>
    {
        List<Category> GetAll();
        void CreateAsync(Category item);
        void UpdateAsync(Category item);
        void DeleteAsync(int? id);

    }
}
