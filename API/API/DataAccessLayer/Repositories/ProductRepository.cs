using API.DataAccessLayer.Interfaces;
using API.DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace API.DataAccessLayer.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        private ShopdbContext _context;

        public ProductRepository(ShopdbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetByCategoryAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var res = await _context.Set<Product>().Where(entity => entity.Id == id)
                .AsNoTracking().ToListAsync(cancellationToken);
            return res;
        }

    }
}
