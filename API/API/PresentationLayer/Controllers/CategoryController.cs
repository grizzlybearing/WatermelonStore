using API.BusinessLogicLayer.DTO.Category;
using API.BusinessLogicLayer.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.PresentationLayer.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;

        public CategoryController(ICategoryService __service)
        {
            _service = __service;
        }

        // GET: api/<CategoryController>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return StatusCode(200, await this._service.GetAllCategoriesAsync());
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return StatusCode(200, await this._service.GetCategoryByIdAsync(id));
        }

        // POST api/<CategoryController>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CategoryAddDTO value)
        {
            return StatusCode(201, await this._service.CreateCategoryAsync(value));
        }

        // PUT api/<CategoryController>/5
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] CategoryUpdateDTO value)
        {
            await this._service.UpdateCategoryAsync(value);
            return StatusCode(200);
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await this._service.DeleteCategoryAsync(id);
            return StatusCode(204);
        }
    }
}
