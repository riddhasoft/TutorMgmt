using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Moring0630ASPCore.Models
{
    public class Floor
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int BuildingId { get; set; }
        [ValidateNever]
        public virtual Building Building { get; set; }
    }
}
