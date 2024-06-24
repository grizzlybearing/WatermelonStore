using System.Collections.Generic;
using System.Threading.Tasks;
using API.DataAccessLayer.Models;

namespace API.DataAccessLayer.Interfaces
{
    public interface IOrdersRepository
    {
      
        Task<IEnumerable<Orders>> GetOrdersByUserIdAsync(Guid userId, CancellationToken cancellationToken = default);
        Task<Orders> GetOrderByIdAsync(Guid orderId, CancellationToken cancellationToken = default);
    }
}
