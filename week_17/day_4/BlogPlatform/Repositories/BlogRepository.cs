using BlogPlatform.Data;
using BlogPlatform.Dto;
using Microsoft.EntityFrameworkCore;
using BlogPlatform.Models;


namespace BlogPlatform.Repositories
{
    public class BlogRepository:IBlogRepository
    {
        private readonly BlogDbContext _context;
        public BlogRepository(BlogDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<PostDto>> GetAllPostWithCommentsAsync()
        {
            return await _context.Posts
            .Include(p => p.Author)
            .Include(p => p.Comments)
            .Select(p => new PostDto
            {
                Id = p.Id,
                AuthorId = p.AuthorId,
                Title = p.Title,
                Content = p.Content,
                PublishedDate = p.PublishedDate,
                IsPublished = p.IsPublished,
                AuthorName = p.Author.FullName,
                Comments = p.Comments.Select(
                    c => new CommentDto
                    {
                        Id = c.Id,
                        PostId = c.PostId,
                        CommenterName = c.CommenterName,
                        Text = c.Text,
                        CreatedAt = c.CreatedAt
                    }).ToList()
            }).ToListAsync();
        }
        public async Task<IEnumerable<PostDto>> GetAllPostIsPublished(int? authorId, DateTime? startDate, DateTime? endDate)
        {
            var query = _context.Posts
                .Include(p => p.Author).Select(p => new ProductDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    StockQuantity = p.StockQuantity,
                    CategoryId = p.CategoryId,
                    CategoryName = p.Category.Name

                }).AsQueryable();
            if (!string.IsNullOrEmpty(searchTerm))
                query = query.Where(p => p.Name.Contains(searchTerm));
            if (categoryId.HasValue)
                query = query.Where(p => p.CategoryId == categoryId.Value);
            if (minPrice.HasValue)
                query = query.Where(p => p.Price >= minPrice.Value);
            if (maxPrice.HasValue)
                query = query.Where(p => p.Price <= maxPrice.Value);
            return await query.ToListAsync();
        }
    }
}
