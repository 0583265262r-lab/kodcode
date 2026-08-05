using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.Xml;

namespace LibraryManagementSystem.Models
{
    [Index(nameof(Email), IsUnique = true)]
    [Index(nameof(MembershipNumber), IsUnique = true)]
    public class MemberModel
//Id(int)
//FullName(string, required, max 100 chars)
//Email(string, required, email format, unique)
//MembershipNumber(string, required, max 20 chars, unique)
//JoinedDate(DateTime)
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string FullName { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        [StringLength(20)]
        public string MembershipNumber { get; set; } = string.Empty;
        public DateTime JoinedDate { get; set; }
    }
}
