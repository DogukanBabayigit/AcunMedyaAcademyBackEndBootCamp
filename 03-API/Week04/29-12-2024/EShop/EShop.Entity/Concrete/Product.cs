using System;
using EShop.Entity.Abstract;

namespace EShop.Entity.Concrete;

public class Product : BaseEntity
{
  private Product() // Ef Core için default constructor oluşturduk. // Reflection ile çalışırken default constructor olması gerekiyor.
  {

  }
  public Product(string name, string properties, decimal price, string imageUrl)
  {
    Name = name;
    Properties = properties;
    Price = price;
    ImageUrl = imageUrl;
  }

  public string Name { get; set; } = string.Empty;
  public string Properties { get; set; } = string.Empty;
  public decimal Price { get; set; }
  public string ImageUrl { get; set; } = string.Empty;
  public ICollection<ProductCategory> ProductCategories { get; set; } = new HashSet<ProductCategory>();// Bir ürünün birden fazla kategorisi olabilir.
}
