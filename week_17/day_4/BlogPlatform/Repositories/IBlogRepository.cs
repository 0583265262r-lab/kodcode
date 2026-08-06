using BlogPlatform.Dto;

namespace BlogPlatform.Repositories
{
    public interface IBlogRepository
    {
        Task<IEnumerable<PostDto>> GetAllPostWithCommentsAsync();
    }
}
