using System.ComponentModel.DataAnnotations;

namespace BlogPlatform.Dto
{
    public class AuthorDto
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime JoineDate { get; set; }
    }
}
