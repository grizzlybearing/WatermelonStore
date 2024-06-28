using API.BusinessLogicLayer.DTO.Product;
using API.BusinessLogicLayer.Interfaces;
using API.DataAccessLayer.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.PresentationLayer.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService __service)
        {
            _service = __service;
        }

        // GET: api/<ProductController>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return StatusCode(200, await this._service.GetAllProductsAsync());
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return StatusCode(200, await this._service.GetProductByIdAsync(id));
        }

        // POST api/<ProductController>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ProductAddDTO value)
        {
            return StatusCode(201, await this._service.CreateProductAsync(value));
        }

        // PUT api/<ProductController>/5
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] ProductUpdateDTO value)
        {
            await this._service.UpdateProductAsync(value);
            return StatusCode(200);
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await this._service.DeleteProductAsync(id);
            return StatusCode(204);
        }

        [HttpGet("/get_by_category/{categoryId}")]
        public async Task<IActionResult> GetByCategory(Guid categoryId)
        {
            return StatusCode(200, await this._service.GetProductsByCategoryAsync(categoryId));
        }
    }
}
