using System;

namespace EShop.Entity.Abstract;

public abstract class BaseEntity
{
  public int Id { get; set; }
  public DateTime CreatedDate { get; set; } = DateTime.UtcNow; // Farklı zaman dilimlerinde çalışan kullanıcılar için UTC kullanıyoruz.
  public DateTime UpdatedDate { get; set; }
  public bool IsActive { get; set; } = true; // Yeni ürün atamaları hep aktif olacak.
  public bool IsDeleted { get; set; } = false; // Ürün silme işlemi yapılacaksa bu alan true olacak.

}using System;
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
} Category Entity'me ait , 10 örnek veri yaratacak HasData komutu hazırlamanı istiyroum. Bu Proje bir eticaret projesi, kategori isimlerini buna göre belirle. Bir de bir kaç kelimeden oluşacak açıklamalar yazmayı ihmal etme. Id'leri birer birer arttır. 10 Kategoriden 2 tanesinin IsActive değeri false olsun. 2 tanesinin ise IsDeleted değeri true olsun.

