using BlogPlatform.Models;
using System.ComponentModel.DataAnnotations;

namespace BlogPlatform.Dto
{
    public class PostDto
    {
        public int Id { get; set; }
        public int AuthorId { get; set; } 
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime PublishedDate { get; set; }
        public bool IsPublished { get; set; }
        //public Author Author { get; set; }
        public string AuthorName { get; set; } = string.Empty;
        public ICollection<CommentDto> Comments { get; set; } = [];
    }
}
