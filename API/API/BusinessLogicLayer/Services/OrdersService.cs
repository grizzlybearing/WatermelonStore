using AutoMapper;
using BLL.Interfaces;
using API.BusinessLogicLayer.DTO.Orders;
using API.DataAccessLayer.Interfaces;
using API.DataAccessLayer.Models;

namespace BLL.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly IOrdersRepository _ordersRepository;
        private readonly IMapper _mapper;

        public OrdersService(IOrdersRepository ordersRepository, IMapper mapper)
        {
            _ordersRepository = ordersRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<OrdersDTO>> GetAllOrdersAsync(CancellationToken cancellationToken = default)
        {
            var orders = await _ordersRepository.GetAllAsync(cancellationToken);
            return _mapper.Map<IEnumerable<OrdersDTO>>(orders);
        }

        public async Task<OrdersDTO> GetOrderByIdAsync(Guid orderId, CancellationToken cancellationToken = default)
        {
            var order = await _ordersRepository.GetOrderByIdAsync(orderId, cancellationToken);
            return _mapper.Map<OrdersDTO>(order);
        }

        public async Task<IEnumerable<OrdersDTO>> GetOrdersByUserIdAsync(Guid userId, CancellationToken cancellationToken = default)
        {
            var orders = await _ordersRepository.GetOrdersByUserIdAsync(userId, cancellationToken);
            return _mapper.Map<IEnumerable<OrdersDTO>>(orders);
        }

        public async Task<OrdersDTO> CreateOrdersAsync(OrdersAddDTO orderAddDTO, CancellationToken cancellationToken = default)
        {
            var order = _mapper.Map<Orders>(orderAddDTO);
            await _ordersRepository.CreateAsync(order, cancellationToken);
            return _mapper.Map<OrdersDTO>(order);
        }

        public async Task UpdateOrdersAsync(OrdersUpdateDTO orderUpdateDTO, CancellationToken cancellationToken = default)
        {
            var order = _mapper.Map<Orders>(orderUpdateDTO);
            await _ordersRepository.UpdateAsync(order, cancellationToken);
        }

        public async Task DeleteOrdersAsync(Guid orderId, CancellationToken cancellationToken = default)
        {
            await _ordersRepository.DeleteAsync(orderId, cancellationToken);
        }
    }
}
