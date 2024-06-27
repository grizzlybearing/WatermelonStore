using API.BusinessLogicLayer.DTO.Orders;

namespace BLL.Interfaces
{
    public interface IOrdersService
    {
        Task<IEnumerable<OrdersDTO>> GetAllOrdersAsync(CancellationToken cancellationToken = default);
        Task<OrdersDTO> GetOrderByIdAsync(Guid orderId, CancellationToken cancellationToken = default);
        Task<IEnumerable<OrdersDTO>> GetOrdersByUserIdAsync(Guid userId, CancellationToken cancellationToken = default);
        Task<OrdersDTO> CreateOrdersAsync(OrdersAddDTO orderAddDTO, CancellationToken cancellationToken = default);
        Task UpdateOrdersAsync(OrdersUpdateDTO orderUpdateDTO, CancellationToken cancellationToken = default);
        Task DeleteOrdersAsync(Guid orderId, CancellationToken cancellationToken = default);
    }
}
