using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Moring0630ASPCore.Models
{
    public class Enrollment
    {
        [Key]
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        [ValidateNever]
        public virtual Course Course { get; set; }
        [ValidateNever]
        public virtual Student Student { get; set; }
    }
}