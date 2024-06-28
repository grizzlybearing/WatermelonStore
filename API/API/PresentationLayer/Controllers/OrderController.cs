using API.BusinessLogicLayer.DTO.Orders;
using API.BusinessLogicLayer.Interfaces;
using AutoMapper;
using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.PresentationLayer.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrdersService _service;

        public OrderController(IOrdersService __service)
        {
            _service = __service;
        }

        // GET: api/<OrderController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return StatusCode(200, await this._service.GetAllOrdersAsync());
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return StatusCode(200, await this._service.GetOrderByIdAsync(id));
        }

        // POST api/<OrderController>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] OrdersAddDTO value)
        {
            return StatusCode(201, await this._service.CreateOrdersAsync(value));
        }

        // PUT api/<OrderController>/5
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] OrdersUpdateDTO value)
        {
            await this._service.UpdateOrdersAsync(value);
            return StatusCode(200);
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await this._service.DeleteOrdersAsync(id);
            return StatusCode(204);
        }

        [HttpDelete("/user/{userId}")]
        public async Task<IActionResult> GetByUser(Guid userId)
        {
            return StatusCode(200, await this._service.GetOrdersByUserIdAsync(userId));
        }
    }
}
