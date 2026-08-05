using System.ComponentModel.DataAnnotations;

namespace BlogPlatform.Models
{
//Post - Id, AuthorId, Title, Body, PublishedDate, IsPublished
    public class Post
    {
        public int Id { get; set; }
        [Required]
        public int AuthorId { get; set; }
        [Required]
        [StringLength(38)]
        public string Title { get; set; } = string.Empty;
        [Required]
        [StringLength(250)]
        public string Content { get; set; } = string.Empty;
        public DateTime PublishedDate { get; set; }
        public bool IsPublished { get; set; }
        public Author Author { get; set; }
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();

    }
}
