using System.Collections.Generic;
using System.Threading.Tasks;
using API.DataAccessLayer.Models;

namespace API.DataAccessLayer.Repositories
{
    public interface IOrderItemsRepository
    {
        Task<IEnumerable<OrderItems>> GetOrderItemsByOrderIdAsync(Guid orderId, CancellationToken cancellationToken = default);
    }
}
