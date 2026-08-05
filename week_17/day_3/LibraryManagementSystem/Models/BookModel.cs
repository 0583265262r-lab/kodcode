using System;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using Microsoft.EntityFrameworkCore;



namespace LibraryManagementSystem.Models

{
    [Index(nameof(ISBN),IsUnique = true)]
    public class BookModel
    //Id(int)
    //Title(string, required, max 200 chars)
    //Author(string, required, max 100 chars)
    //ISBN(string, required, max 20 chars, unique)
    //PublishedYear(int, range 1800 - 2100)
    //AvailableCopies(int, min 0)
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Titel { get; set; } = string.Empty;
        [Required]
        [StringLength(100)]
        public string Author { get; set; } = string.Empty;
        [Required]
        [StringLength(20)]
        public string ISBN { get; set; } = string.Empty;
        [Range(1800 ,2100)]
        public int PublishedYear { get; set; }
        [Range(0,int.MaxValue)]
        public int AvailableCopies { get; set; }
    }
}
