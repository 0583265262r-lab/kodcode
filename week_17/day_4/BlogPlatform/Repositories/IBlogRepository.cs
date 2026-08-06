using BlogPlatform.Dto;
using Microsoft.AspNetCore.Mvc;

namespace BlogPlatform.Repositories
{
    public interface IBlogRepository
    {
        Task<IEnumerable<PostDto>> GetAllPostWithCommentsAsync();
        Task<IEnumerable<PostDto>> GetAllPostIsPublished(int? authorId, DateTime? startDate, DateTime? endDate);
        Task<IEnumerable<PostDto>> SortAllPostByDateOrTitle([FromQuery] string? sortBy, [FromQuery] string? sortOrder);
        Task<IEnumerable<PostCommentCountDto>> AggregationPerItem();
        Task<IEnumerable<object>> GetPostCountPerAuthorAsync();
        Task<IEnumerable<object>> GetTotalCommentsPerAuthorAsync();
    }
}
