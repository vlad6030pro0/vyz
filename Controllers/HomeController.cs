using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using vyz.Models;
using vyz.Services.Interfaces;

namespace vyz.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IAddStudentService addStudentService;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        //this.addStudentService = addStudentService;
    }

    
    public IActionResult Registration()
    {
        return View();
    }
    public IActionResult Index()
    {
        return View();
    }
}
