using System;

namespace EShop.Entity.Abstract;

public abstract class BaseEntity
{
  public int Id { get; set; }
  public DateTime CreatedDate { get; set; } = DateTime.UtcNow; // Farklı zaman dilimlerinde çalışan kullanıcılar için UTC kullanıyoruz.
  public DateTime UpdatedDate { get; set; }
  public bool IsActive { get; set; } = true; // Yeni ürün atamaları hep aktif olacak.
  public bool IsDeleted { get; set; } = false; // Ürün silme işlemi yapılacaksa bu alan true olacak.

}
