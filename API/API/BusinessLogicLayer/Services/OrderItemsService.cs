using AutoMapper;
using API.BusinessLogicLayer.DTO.OrderItems;
using API.BusinessLogicLayer.Interfaces;
using API.DataAccessLayer.Models;
using API.DataAccessLayer.Repositories;

namespace BLL.Services
{
    public class OrderItemService : IOrderItemsService
    {
        private readonly IOrderItemsRepository _orderItemsRepository;
        private readonly IMapper _mapper;

        public OrderItemService(IOrderItemsRepository orderItemsRepository, IMapper mapper)
        {
            _orderItemsRepository = orderItemsRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<OrderItemsDTO>> GetAllOrderItemsAsync(CancellationToken cancellationToken = default)
        {
            var orderItems = await _orderItemsRepository.GetAllAsync(cancellationToken);
            return _mapper.Map<IEnumerable<OrderItemsDTO>>(orderItems);
        }

        public async Task<OrderItemsDTO> GetOrderItemByIdAsync(Guid orderItemId, CancellationToken cancellationToken = default)
        {
            var orderItem = await _orderItemsRepository.GetAsync(orderItemId, cancellationToken);
            return _mapper.Map<OrderItemsDTO>(orderItem);
        }

        public async Task<IEnumerable<OrderItemsDTO>> GetOrderItemsByOrderIdAsync(Guid orderId, CancellationToken cancellationToken = default)
        {
            var orderItems = await _orderItemsRepository.GetOrderItemsByOrderIdAsync(orderId, cancellationToken);
            return _mapper.Map<IEnumerable<OrderItemsDTO>>(orderItems);
        }

        public async Task<OrderItemsDTO> CreateOrderItemAsync(OrderItemsAddDTO orderItemAddDTO, CancellationToken cancellationToken = default)
        {
            var orderItem = _mapper.Map<OrderItems>(orderItemAddDTO);
            await _orderItemsRepository.CreateAsync(orderItem, cancellationToken);
            return _mapper.Map<OrderItemsDTO>(orderItem);
        }

        public async Task UpdateOrderItemAsync(OrderItemsUpdateDTO orderItemUpdateDTO, CancellationToken cancellationToken = default)
        {
            var orderItem = _mapper.Map<OrderItems>(orderItemUpdateDTO);
            await _orderItemsRepository.UpdateAsync(orderItem, cancellationToken);
        }

        public async Task DeleteOrderItemAsync(Guid orderItemId, CancellationToken cancellationToken = default)
        {
            await _orderItemsRepository.DeleteAsync(orderItemId, cancellationToken);
        }
    }
}
