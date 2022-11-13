using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstProj.Models;
using FirstProj.Data;

namespace FirstProj.Controllers;

public class HomeController : Controller
{
    private readonly GAMFDbContext _dbContext;

    public HomeController(GAMFDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IActionResult Index()
    {
        var students = _dbContext.Students != null ? _dbContext.Students.ToList() : new List<Student>();
        return View(students);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

