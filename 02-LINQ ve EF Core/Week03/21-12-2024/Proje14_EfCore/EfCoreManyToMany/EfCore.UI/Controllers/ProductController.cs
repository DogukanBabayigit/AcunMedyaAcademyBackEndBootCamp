using EfCore.Business.Abstract;
using EfCore.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace EfCore.UI.Controllers
{
    public class ProductController : Controller
    {
        // GET: ProductController
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        public async Task<ActionResult> Index()
        {
            var products = await _productService.GetProductsAsync();
            return View(products ?? new List<ProductDto>());
        }

    }
}
