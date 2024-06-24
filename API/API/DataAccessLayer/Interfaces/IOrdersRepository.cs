using System.Collections.Generic;
using System.Threading.Tasks;
using API.DataAccessLayer.Models;

namespace API.DataAccessLayer.Interfaces
{
    public interface IOrdersRepository
    {
        Task<Orders> CreateOrderAsync(Orders order);
        Task<IEnumerable<Orders>> GetAllOrdersAsync();
        Task<IEnumerable<Orders>> GetOrdersByUserIdAsync(int userId);
        Task<Orders> GetOrderByIdAsync(int orderId);
    }
}
