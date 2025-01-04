using System;
using EShop.Entity.Abstract;

namespace EShop.Entity.Concrete;

public class Category : BaseEntity
{
  private Category() // Ef Core için default constructor oluşturduk. // Reflection ile çalışırken default constructor olması gerekiyor.
  {

  }
  public Category(string name, string imageUrl)
  {
    Name = name;
    ImageUrl = imageUrl;
  }
  public string Name { get; set; } = string.Empty; // Boş bir string olmasını istiyoruz.
  public string? Description { get; set; } // Kategori açıklaması boş olabileceği için nullable tanımladık(?).
  public string ImageUrl { get; set; } = string.Empty;
  public ICollection<ProductCategory> ProductCategories { get; set; } = new HashSet<ProductCategory>(); // Bir kategorinin birden fazla ürünü olabilir. // Default olarak boş bir liste oluşturduk.
}
