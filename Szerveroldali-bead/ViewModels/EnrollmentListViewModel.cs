using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Szerveroldalibead.ViewModels
{
    public class EnrollmentListViewModel
    {
        [Display(Name = "Tantárgy")]
        public string CourseTitle { get; set; }
        [Display(Name = "Hallgató")]
        public string StudentFullName { get; set; }
        [Display(Name = "Érdemjegy")]
        public string Grade { get; set; }

        public EnrollmentListViewModel()
        {
        }
    }
}

