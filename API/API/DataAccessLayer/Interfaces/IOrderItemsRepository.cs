using System.Collections.Generic;
using System.Threading.Tasks;
using API.DataAccessLayer.Interfaces;
using API.DataAccessLayer.Models;

namespace API.DataAccessLayer.Repositories
{
    public interface IOrderItemsRepository : IBaseRespository<OrderItems>
    {
        Task<IEnumerable<OrderItems>> GetOrderItemsByOrderIdAsync(Guid orderId, CancellationToken cancellationToken = default);
    }
}
