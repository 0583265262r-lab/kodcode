using BlogPlatform.Dto;
using BlogPlatform.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BlogPlatform.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogPlatformController:ControllerBase
    {
        private readonly IBlogRepository _repository;
        public BlogPlatformController(IBlogRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostDto>>> GetAll()
                => Ok(await _repository.GetAllPostWithCommentsAsync());
        [HttpGet("PostIsPublished")]
        public async Task<ActionResult<IEnumerable<PostDto>>> GetPostIsPublished(int? authorId, DateTime? startDate, DateTime? endDate)
            => Ok(await _repository.GetAllPostIsPublished(authorId, startDate, endDate));
        [HttpGet("sorted")]
        public async Task<ActionResult<IEnumerable<PostDto>>> SortPostByDateOrTitle([FromQuery] string? sortBy, [FromQuery] string? sortOrder)
            => Ok(await _repository.SortAllPostByDateOrTitle(sortBy, sortOrder));
        [HttpGet("PostCommentCountDto")]
        public async Task<ActionResult<IEnumerable<PostCommentCountDto>>> AggregationPerItem()
            =>Ok(await _repository.AggregationPerItem());
        [HttpGet("PostCountPerAuthor")]
        public async Task<ActionResult<IEnumerable<object>>>PostCountPerAuthorAsync()
            => Ok(await _repository.GetPostCountPerAuthorAsync());
        [HttpGet("TotalCommentsPerAuthor")]
        public async Task<ActionResult<IEnumerable<object>>> GetTotalCommentsPerAuthorAsync()
            => Ok (await _repository.GetTotalCommentsPerAuthorAsync());

    }
}
