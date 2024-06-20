using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace API.DataAccessLayer.Repositories
{
    public class OrderItemsRepository : IOrderItemsRepository
    {
        private readonly ShopdbContext _dbContext;

        public OrderItemsRepository(ShopdbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<OrderItems>> GetOrderItemsByOrderIdAsync(int orderId)
        {
            return await _dbContext.OrderItems
                                    .Where(oi => oi.OrderId == orderId)
                                    .Include(oi => oi.Product)
                                    .ToListAsync();
        }
    }
}
