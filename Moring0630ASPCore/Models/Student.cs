
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Moring0630ASPCore.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [StringLength(100)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Date Of Enrollment")]
        public DateTime DateOfEnrollment { get; set; }

    }
}
