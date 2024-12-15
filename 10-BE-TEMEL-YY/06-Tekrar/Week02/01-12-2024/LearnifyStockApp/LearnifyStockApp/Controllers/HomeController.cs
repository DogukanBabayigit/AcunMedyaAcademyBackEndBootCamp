using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LearnifyStockApp.Models;
using LearnifyStockApp.Models.Repositories;

namespace LearnifyStockApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly CategoryRepository _categoryRepository;
    private readonly ProductRepository _productRepository;
    public HomeController(ILogger<HomeController> logger, CategoryRepository categoryRepository, ProductRepository productRepository)
    {
        _logger = logger;
        _categoryRepository = categoryRepository;
        _productRepository = productRepository;
    }

    public async Task<IActionResult> Index()
    {
        var result = await _categoryRepository.GetTopSellingCategoryAsync();
        var productCount = await _productRepository.GetProductsCountAsync();
        ViewBag.CategoryName = result.CategoryName;
        ViewBag.TotalSales = result.TotalSales;
        ViewBag.ProductCount=productCount;
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
