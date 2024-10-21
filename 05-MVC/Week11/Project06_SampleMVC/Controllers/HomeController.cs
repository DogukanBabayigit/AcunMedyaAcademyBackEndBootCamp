using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Project06_SampleMVC.Models;

namespace Project06_SampleMVC.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

}
