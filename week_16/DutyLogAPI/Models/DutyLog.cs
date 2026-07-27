using System.ComponentModel.DataAnnotations;


namespace DutyLogAPI.Models
{
    public class DutyLog
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "The length of the name must be between 5 - 15")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "StationName is required")]
        [StringLength(30, MinimumLength = 10, ErrorMessage = "The length of the StationName must be between 10 - 30")]
        public string StationName { get; set; } = string.Empty;
       
        [Required(ErrorMessage = "ShiftStart is required")]
        public DateTime ShiftStart { get; set; }
        public DateTime? ShiftEnd { get; set; }
        [StringLength(500, ErrorMessage = "Remarks cannot exceed 500 characters")]
        public string? Remarks { get; set; }


    }
}
