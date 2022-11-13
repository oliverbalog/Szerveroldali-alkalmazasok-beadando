﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Szerveroldali_bead.Models;
using Szerveroldali_bead.Data;

namespace Szerveroldali_bead.Controllers;

public class HomeController : Controller
{
    private readonly GAMFDbContext _dbContext;

    public HomeController(GAMFDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IActionResult Index()
    {
        return View();
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

