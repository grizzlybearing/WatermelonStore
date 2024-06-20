using API.DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace API.DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryRepository<Category>
    {
        private ShopdbContext _dbContext;


        public CategoryRepository(ShopdbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async void CreateAsync(Category category)
        {
            if (category != null)
            {
                _dbContext.Categories.Add(category);
                await _dbContext.SaveChangesAsync();
            }
            else throw new Exception("Object is Null");
        }

        public async void DeleteAsync(int? id)
        {
            if (id != null)
            {
                Category? category = await _dbContext.Categories.FirstOrDefaultAsync(p => p.Id == id);
                if (category != null)
                {
                    _dbContext.Categories.Remove(category);
                    await _dbContext.SaveChangesAsync();
                }
                else throw new Exception("Category is not found");
            }
            else throw new Exception("Category is not selected");
        }

        public async void UpdateAsync(Category category)
        {
            if (category != null)
            {
                _dbContext.Categories.Update(category);
                await _dbContext.SaveChangesAsync();
            }
            else throw new Exception("Category is not selected");
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            if (_dbContext.Categories == null) throw new Exception("Categories are not found");
            else return await _dbContext.Categories.ToListAsync();
        }

    }
}
