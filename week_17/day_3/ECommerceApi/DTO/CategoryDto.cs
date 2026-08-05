using ECommerceApi.Models;
using System.ComponentModel.DataAnnotations;

namespace ECommerceApi.DTO
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<ProductDto> Products { get; set; } = new List<ProductDto>();
    }
}
