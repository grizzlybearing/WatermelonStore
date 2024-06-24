using API.DataAccessLayer.Interfaces;
using API.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace API.DataAccessLayer.Repositories
{
    public class OrdersRepository : BaseRepository<Orders>, IOrdersRepository
    {
        private readonly ShopdbContext _context;

        public OrdersRepository(ShopdbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Orders>> GetOrdersByUserIdAsync(Guid userId, CancellationToken cancellationToken = default)
        {
            return await _context.Orders
                                 .Where(order => order.UserId == userId)
                                 .Include(order => order.User)
                                 .Include(order => order.OrderItems)
                                 .ThenInclude(orderItem => orderItem.Product)
                                 .ToListAsync(cancellationToken);
        }

        public async Task<Orders?> GetOrderByIdAsync(Guid orderId, CancellationToken cancellationToken = default)
        {
            return await _context.Orders
                                 .Include(order => order.User)
                                 .Include(order => order.OrderItems)
                                 .ThenInclude(orderItem => orderItem.Product)
                                 .FirstOrDefaultAsync(order => order.Id == orderId, cancellationToken);
        }
    }
}
