using LearnifyStockApp.Models.Repositories;
using LearnifyStockApp.Models.ViewModels.ProductViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LearnifyStockApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductRepository _productRepository;
        private readonly CategoryRepository _categoryRepository;
        private readonly SupplierRepository _supplierRepository;

        public ProductController(ProductRepository productRepository, CategoryRepository categoryRepository, SupplierRepository supplierRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _supplierRepository = supplierRepository;
        }

        public async Task<ActionResult> Index(bool id)
        {
            bool isDeleted = id;
            ViewBag.IsDeleted = isDeleted;
            var products = await _productRepository.GetAllAsync(isDeleted);
            return View(products);
        }

        [NonAction]
        private async Task<List<SelectListItem>> GenerateCategoryList()
        {
            var categories = await _categoryRepository.GetAllAsync(false);
            List<SelectListItem> categorySelectList = [];
            foreach (var category in categories)
            {
                categorySelectList.Add(new SelectListItem
                {
                    Text = category.Name,
                    Value = category.Id.ToString()
                });
            }
            return categorySelectList;
        }

        [NonAction]
        private async Task<List<SelectListItem>> GenerateSupplierList()
        {
            var suppliers = await _supplierRepository.GetAllAsync(false);
            List<SelectListItem> supplierSelectList = [];
            foreach (var supplier in suppliers)
            {
                supplierSelectList.Add(new SelectListItem
                {
                    Text = supplier.Name,
                    Value = supplier.Id.ToString()
                });
            }
            return supplierSelectList;
        }

        public async Task<ActionResult> Add()
        {
            AddProductViewModel model = new()
            {
                CategoryList = await GenerateCategoryList(),
                SupplierList = await GenerateSupplierList()
            };
            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> Add(AddProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _productRepository.AddAsync(model);
                return RedirectToAction("Index");
            }
            model.CategoryList = await GenerateCategoryList();
            model.SupplierList = await GenerateSupplierList();
            return View(model);
        }

        public async Task<ActionResult> Edit(int id)
        {
            var product = await _productRepository.GetAsync(id);
            var model = new UpdateProductViewModel
            {
                Id = product.Id,
                Description = product.Description,
                MinimumStockLevel = product.MinimumStockLevel,
                Name = product.Name,
                Price = product.Price,
                StockQuantity = product.StockQuantity,
                UpdatedAt = product.UpdatedAt,
                CategoryList = await GenerateCategoryList(),
                SupplierList = await GenerateSupplierList()
            };
            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(UpdateProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _productRepository.UpdateAsync(model);
                return RedirectToAction("Index");
            }
            model.CategoryList = await GenerateCategoryList();
            model.SupplierList = await GenerateSupplierList();
            return View(model);
        }

        public async Task<ActionResult> SoftDelete(int id)
        {
            var isDeleted = await _productRepository.SoftDeleteAsync(id);
            return RedirectToAction("Index", new { Id = isDeleted });
        }

        public async Task<ActionResult> HardDelete(int id)
        {
            await _productRepository.HardDeleteAsync(id);
            return RedirectToAction("Index");
        }





    }
}
