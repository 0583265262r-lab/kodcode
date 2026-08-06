using BlogPlatform.Data;
using BlogPlatform.Dto;
using BlogPlatform.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using System.Text;


namespace BlogPlatform.Repositories
{
    
    public class BlogRepository:IBlogRepository
    {
        
        private readonly BlogDbContext _context;
        public BlogRepository(BlogDbContext context)
        {
            _context = context;
        }
        public IEnumerable<PostDto> GetAllPost()
        {
                return _context.Posts
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
                }).AsQueryable();
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
                .Include(p => p.Author)
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
                })
                .Where(p => p.IsPublished).AsQueryable();
                
            if (authorId.HasValue)
                query = query.Where(p => p.AuthorId == authorId.Value);
            if (startDate.HasValue)
                query = query.Where(p=> p.PublishedDate>=startDate.Value);
            if (endDate.HasValue)
                query = query.Where(p => p.PublishedDate >= endDate.Value);

            return await query.ToListAsync();
        }
        public async Task<IEnumerable<PostDto>> SortAllPostByDateOrTitle([FromQuery] string? sortBy, [FromQuery] string? sortOrder)
        {
            var query = 
            _context.Posts
                .Include(p => p.Author)
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
                }).AsQueryable();
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                if (sortOrder == "desc")
                {
                    query = sortBy.ToLower() switch
                    {
                        "title" => query.OrderByDescending(p => p.Title),
                        "publisheddate" => query.OrderByDescending(p => p.PublishedDate),
                        _ => query
                    }; 
                }
                else
                {
                    query = sortBy.ToLower() switch
                    {
                        "title" => query.OrderBy(p => p.Title),
                        "publisheddate" => query.OrderBy(p => p.PublishedDate),
                        _ => query
                    };
                }
            }
            return await query.ToListAsync();
        }
        public async Task<IEnumerable<PostCommentCountDto>> AggregationPerItem()
        {
            return await _context.Posts
                        .Select(p => new PostCommentCountDto
                        {
                            Title = p.Title,
                            CommentCount = p.Comments.Count()
                        })
                        .ToListAsync();
        }
        public async Task<IEnumerable<object>> GetPostCountPerAuthorAsync()
        {
            return await _context.Authors
                .Select(author => new
                {
                    AuthorName = author.FullName,
                    PostCount = author.Posts.Count()
                })
                .ToListAsync(); 
        }
        public async Task<IEnumerable<object>> GetTotalCommentsPerAuthorAsync()
        {
            return await _context.Authors
                .Select(author => new
                {
                    AuthorName = author.FullName,
                    CommentCount = author.Posts.SelectMany(p => p.Comments).Count()
                })
                .ToListAsync();
        }

    }
}
