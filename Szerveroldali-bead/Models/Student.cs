using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstProj.Models
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Display(Name = "Családnév")]
        public string LastName { get; set; } = "";
        [Display(Name = "Keresztnév")]
        public string FirstName { get; set; } = "";
        [Display(Name = "Első jelentkezés")]
        public DateTimeOffset EnrollmentDate { get; set; }
        [Display(Name = "Jelentkezések")]
        public virtual ICollection<Enrollment>? Enrollments { get; set; }
    }
}

