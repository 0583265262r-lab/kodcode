
using System.ComponentModel.DataAnnotations;

namespace BlogPlatform.Models
{
    //Author - Id, FullName, Email, JoinedDate

    public class Author
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FullName { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public DateTime JoineDate { get; set; }
        public ICollection<Post> Posts { get; set; } = new List<Post>();
    }
}
