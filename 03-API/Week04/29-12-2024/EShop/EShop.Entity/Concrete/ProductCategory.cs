using System;

namespace EShop.Entity.Concrete;

public class ProductCategory
{
  private ProductCategory() // Ef Core için default constructor oluşturduk. // Reflection ile çalışırken default constructor olması gerekiyor.
  {

  }
  public ProductCategory(int productId, int categoryId)
  {
    ProductId = productId;
    CategoryId = categoryId;
  }

  public int ProductId { get; set; }
  public Product? Product { get; set; } // Product tüm alanları ile birlikte gelmesi için.
  public int CategoryId { get; set; }
  public Category? Category { get; set; } // Category tüm alanları ile birlikte gelmesi için.

}
