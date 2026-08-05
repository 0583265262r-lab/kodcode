using ECommerceApi.Models;
using ECommerceApi.Repositories;
using ECommerceApi.DTO;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController: ControllerBase
    {
        private readonly IProductRepository _repository;
        public ProductsController(IProductRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetAll()
                => Ok(await _repository.GetAllWithCategoryAsync());
        [HttpGet("/Full-Tree")]
        public async Task<ActionResult<IEnumerable<Category>>>GetCategoriesWithFullTreeAsync()
            => Ok(await _repository.GetCategoriesWithFullTreeAsync());
            
    }

}
