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
        [HttpGet("Full-Tree")]
        public async Task<ActionResult<IEnumerable<Category>>>GetCategoriesWithFullTreeAsync()
            => Ok(await _repository.GetCategoriesWithFullTreeAsync());
        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<Product>>> SearchAsync(string? searchTerm,
                         int? categoryId, decimal? minPrice, decimal? maxPrice)
            => Ok(await _repository.SearchAsync(searchTerm,
                         categoryId, minPrice, maxPrice));
        [HttpGet("sorted")]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetSortedAsync(string? sortBy, bool descending)
            => Ok(await _repository.GetSortedAsync(sortBy, descending));


    }

}
