using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LearnifyStockApp.Models.ViewModels.ProductViewModels;

public class AddProductViewModel
{
    [Display(Name = "Ürün")]
    [Required(ErrorMessage = "Bu alan boş bırakılmamalıdır.")]
    public string? Name { get; set; }

    [Display(Name = "Açıklama")]
    [Required(ErrorMessage = "Bu alan boş bırakılmamalıdır.")]
    public string? Description { get; set; }
    public int CategoryId { get; set; }

    [Display(Name = "Kategori")]
    public List<SelectListItem>? CategoryList { get; set; }
    public int SupplierId { get; set; }

    [Display(Name = "Tedarikçi")]
    public List<SelectListItem>? SupplierList { get; set; }

    [Display(Name = "Stok Miktarı")]
    [Required(ErrorMessage = "Bu alan boş bırakılmamalıdır.")]
    public int? StockQuantity { get; set; } = 0;

    [Display(Name = "Stok Seviyesi")]
    [Required(ErrorMessage = "Bu alan boş bırakılmamalıdır.")]
    public int? MinimumStockLevel { get; set; } = 0;

    [Display(Name = "Fiyat")]
    [Required(ErrorMessage = "Bu alan boş bırakılmamalıdır.")]
    public decimal? Price { get; set; } = 0;
}
