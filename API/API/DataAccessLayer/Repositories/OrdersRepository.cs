using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DataAccessLayer.Interfaces;
using API.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace API.DataAccessLayer.Repositories
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly ShopdbContext _dbContext;

        public OrdersRepository(ShopdbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Orders> CreateOrderAsync(Orders order)
        {
            _dbContext.Orders.Add(order);
            await _dbContext.SaveChangesAsync();
            return order;
        }

        public async Task<IEnumerable<Orders>> GetAllOrdersAsync()
        {
            return await _dbContext.Orders
                                    .Include(o => o.User)
                                    .Include(o => o.OrderItems)
                                        .ThenInclude(oi => oi.Product)
                                    .ToListAsync();
        }

        public async Task<IEnumerable<Orders>> GetOrdersByUserIdAsync(int userId)
        {
            return await _dbContext.Orders
                                    .Where(o => o.UserId == userId)
                                    .Include(o => o.User)
                                    .Include(o => o.OrderItems)
                                        .ThenInclude(oi => oi.Product)
                                    .ToListAsync();
        }

        public async Task<Orders> GetOrderByIdAsync(int orderId)
        {
            return await _dbContext.Orders
                                    .Include(o => o.User)
                                    .Include(o => o.OrderItems)
                                        .ThenInclude(oi => oi.Product)
                                    .FirstOrDefaultAsync(o => o.Id == orderId);
        }
    }
}
