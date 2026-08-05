using ECommerceApi.Models;
using ECommerceApi.DTO;

namespace ECommerceApi.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> GetAllWithCategoryAsync();
        Task<IEnumerable<CategoryDto>> GetCategoriesWithFullTreeAsync();
        Task<IEnumerable<ProductDto>> SearchAsync(string? searchTerm, int? categoryId, decimal? minPrice, decimal? maxPrice);
        Task<IEnumerable<ProductDto>> GetSortedAsync(string? sortBy, bool  descending);
        Task<IEnumerable<object>> GetProductRatingsAsync();
        Task<IEnumerable<object>> GetProductCountByCategoryAsync();
        Task<(IEnumerable<Product> Products, int TotalCount)> GetPagedAsync(int page, int pageSize);

    }
}
