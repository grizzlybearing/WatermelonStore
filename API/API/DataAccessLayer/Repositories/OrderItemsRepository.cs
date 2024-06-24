using API.DataAccessLayer.Interfaces;
using API.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace API.DataAccessLayer.Repositories
{
    public class OrderItemsRepository : BaseRepository<OrderItems>, IOrderItemsRepository
    {
        private readonly ShopdbContext _context;

        public OrderItemsRepository(ShopdbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<OrderItems>> GetItemsByOrderIdAsync(Guid orderId, CancellationToken cancellationToken = default)
        {
            return await _context.OrderItems
                                 .Where(item => item.OrderId == orderId)
                                 .Include(item => item.Product)
                                 .ToListAsync(cancellationToken);
        }
    }
}
