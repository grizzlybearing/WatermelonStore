using API.DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace API.DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryRepository<Category>
    {
        private ShopdbContext _dbContext;
        ShopdbContext db;

        public CategoryRepository(ShopdbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async void CreateAsync(Category category)
        {
            if (category != null)
            {
                _dbContext.Categories.Add(category);
                await db.SaveChangesAsync();
            }
            else throw new Exception("Object is Null");
        }

        public async void DeleteAsync(int? id)
        {
            if (id != null)
            {
                Category? category = await db.Categories.FirstOrDefaultAsync(p => p.Id == id);
                if (category != null)
                {
                    _dbContext.Categories.Remove(category);
                    await db.SaveChangesAsync();
                }
                else throw new Exception("Category is not found");
            }
            else throw new Exception("Category is not selected");
        }

        public async void UpdateAsync(Category category)
        {
            if (category != null)
            {
                db.Categories.Update(category);
                await db.SaveChangesAsync();
            }
            else throw new Exception("Category is not selected");
        }

        public List<Category> GetAll()
        {
            if (db.Categories == null) throw new Exception("Categories are not found");
            else return db.Categories.ToList();
        }

    }
}
