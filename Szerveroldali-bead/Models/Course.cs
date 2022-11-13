using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Szerveroldali_bead.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseId { get; set; }
        [Display(Name = "Megnevezés")]
        public string Title { get; set; } = "";
        [Display(Name = "Kreditek")]
        public int Credits { get; set; }
        [Display(Name = "Jelentkezések")]
        public virtual ICollection<Enrollment>? Enrollments { get; set; }
    }
}