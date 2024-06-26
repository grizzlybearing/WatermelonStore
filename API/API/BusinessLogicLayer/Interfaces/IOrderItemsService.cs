using API.BusinessLogicLayer.DTO.OrderItems;

namespace API.BusinessLogicLayer.Interfaces
{
    public interface IOrderItemsService
    {
        Task<IEnumerable<OrderItemsDTO>> GetAllOrderItemsAsync(CancellationToken cancellationToken = default);
        Task<OrderItemsDTO> GetOrderItemByIdAsync(Guid orderItemsId, CancellationToken cancellationToken = default);
        Task<IEnumerable<OrderItemsDTO>> GetOrderItemsByOrderIdAsync(Guid orderId, CancellationToken cancellationToken = default);
        Task<OrderItemsDTO> CreateOrderItemAsync(OrderItemsAddDTO orderItemAddDTO, CancellationToken cancellationToken = default);
        Task UpdateOrderItemAsync(OrderItemsUpdateDTO orderItemUpdateDTO, CancellationToken cancellationToken = default);
        Task DeleteOrderItemAsync(Guid orderItemId, CancellationToken cancellationToken = default);
    }
}
