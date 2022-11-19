using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Szerveroldali_bead.Data;
using Szerveroldalibead.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Szerveroldalibead.Controllers
{
    public class ReportController : Controller
    {
        private readonly GAMFDbContext _context;

        public ReportController(GAMFDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IActionResult EnrollmentDateReport()
        {
            var result = _context.Students.GroupBy(s => s.EnrollmentDate)
                .Select(s => new EnrollmentDateViewModel
                {
                    EnrollmentDate = s.Key,
                    StudentCount = s.Count()
                });


            return View(result.ToList());
        }

        [HttpGet("/Report/StudentsCredit")]
        public async Task<IActionResult> StudentsCredits()
        {
            var students = await _context.Students
                .Include(x => x.Enrollments)
                    .ThenInclude(z => z.Course).ToListAsync();

            var result = students.Select(x => new StudentsCreditsViewModel
            {
                Student = x,
                Credits = x.Enrollments.Sum(x => x.Course.Credits)
            });

            return View("StudentsCreditReport", result);
        }

    }
}

