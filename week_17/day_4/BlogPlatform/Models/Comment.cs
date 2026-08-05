using System.ComponentModel.DataAnnotations;

namespace BlogPlatform.Models
{
    //Comment - Id, PostId, CommenterName, Text, CreatedAt
    public class Comment
    {
        public int Id { get; set; }
        [Required]
        public int PostId { get; set; }
        [Required]
        [StringLength(35)]
        public string CommenterName { get; set; } = string.Empty;
        [Required]
        [StringLength(250)]
        public string Text { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public Post Post { get; set; }
    }   
}
