using System.ComponentModel.DataAnnotations;

namespace Moring0630ASPCore.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [Required]
        [Range(1, 4)]
        public decimal Credits { get; set; }

    }
}
