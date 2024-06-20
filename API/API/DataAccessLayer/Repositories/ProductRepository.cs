using API.DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace API.DataAccessLayer.Repositories
{
    public class ProductRepository : IProductRepository<Product>
    {
        private ShopdbContext _dbContext;

        public ProductRepository(ShopdbContext dbContext) {
            _dbContext = dbContext;
        }

        public async void CreateAsync(Product? product)
        {
            if (product != null)
            {
                _dbContext.Products.Add(product);
                await _dbContext.SaveChangesAsync();
            }
            else throw new Exception("Object is Null");
        }

        public async void DeleteAsync(int? id) {
            if (id != null)
            {
                Product? product = await _dbContext.Products.FirstOrDefaultAsync(p => p.Id == id);
                if (product != null)
                {
                    _dbContext.Products.Remove(product);
                    await _dbContext.SaveChangesAsync();
                }
                else throw new Exception("Product is not found");
            }
            else throw new Exception("Product is not selected");
        }

        public async void UpdateAsync(Product? product)
        {
            if (product != null)
            {
                _dbContext.Products.Update(product);
                await _dbContext.SaveChangesAsync();
            }
            else throw new Exception("Product is not selected");

        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            if (_dbContext.Products == null) throw new Exception("Products are not found");
            else return await _dbContext.Products.ToListAsync();
        }

        public async Task<Product> GetbyIdAsync(int? id)
        {
            if (id != null)
            {
                var product = await _dbContext.Products.FirstOrDefaultAsync(p => p.Id == id);
                if (product != null)
                {
                    return product;
                }
                else throw new Exception("Product is not found");
            }
            else throw new Exception("Product is not selected");
        }

        public async Task<IEnumerable<Product>> GetByCategoryAsync(int? category)
        {
            if (category != null)
            {
                var products = _dbContext.Products.Where(p=> p.CategoryId == category);
                if (products != null)
                {
                    return products;
                }
                else throw new Exception("Products in this category are not found");
            }
            else throw new Exception("Category is not selected");
        }

    }
}
