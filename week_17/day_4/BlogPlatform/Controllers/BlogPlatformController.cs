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
    }
}
