using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LearnifyStockApp.Models.ViewModels.ProductViewModels;

public class UpdateProductViewModel
{
    public int Id { get; set; }

    [Display(Name = "Ürün")]
    [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
    public string? Name { get; set; }

    [Display(Name = "Açıklama")]
    [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
    public string? Description { get; set; }
    public int CategoryId { get; set; }

    [Display(Name = "Kategori")]
    public List<SelectListItem>? CategoryList { get; set; }
    public int SupplierId { get; set; }

    [Display(Name = "Tedarikçi")]
    public List<SelectListItem>? SupplierList { get; set; }

    [Display(Name = "Stok Miktarı")]
    [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
    public int? StockQuantity { get; set; }


    [Display(Name = "Stok Seviyesi")]
    [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
    public int? MinimumStockLevel { get; set; }

    [Display(Name = "Fiyat")]
    [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
    public decimal? Price { get; set; }

    [Display(Name = "Son Güncelleme Tarihi: ")]
    public DateTime? UpdatedAt { get; set; }
}
