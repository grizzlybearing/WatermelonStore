using API.DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace API.DataAccessLayer.Repositories
{
    public class ProductRepository : IProductRepository<Product>
    {
        private ShopdbContext _dbContext;
        ShopdbContext db;

        public ProductRepository(ShopdbContext dbContext) {
            _dbContext = dbContext;
        }

        public async void CreateAsync(Product? product)
        {
            if (product != null)
            {
                _dbContext.Products.Add(product);
                await db.SaveChangesAsync();
            }
            else throw new Exception("Object is Null");
        }

        public async void DeleteAsync(int? id) {
            if (id != null)
            {
                Product? product = await db.Products.FirstOrDefaultAsync(p => p.Id == id);
                if (product != null)
                {
                    _dbContext.Products.Remove(product);
                    await db.SaveChangesAsync();
                }
                else throw new Exception("Product is not found");
            }
            else throw new Exception("Product is not selected");
        }

        public async void UpdateAsync(Product? product)
        {
            if (product != null)
            {
                db.Products.Update(product);
                await db.SaveChangesAsync();
            }
            else throw new Exception("Product is not selected");

        }

        public List<Product> GetAll()
        {
            if (db.Products == null) throw new Exception("Products are not found");
            else return db.Products.ToList();
        }

        public Product GetbyId(int? id)
        {
            if (id != null)
            {
                Product? product = db.Products.FirstOrDefault(p => p.Id == id);
                if (product != null)
                {
                    return product;
                }
                else throw new Exception("Product is not found");
            }
            else throw new Exception("Product is not selected");
        }

        public IQueryable<Product> GetByCategory(int? category)
        {
            if (category != null)
            {
                var products = db.Products.Where(p=> p.CategoryId == category);
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
