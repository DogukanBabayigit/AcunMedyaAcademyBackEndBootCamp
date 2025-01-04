using System;
using System.Security;
using EShop.Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace EShop.Data.Concrete.Context;

// Hem IdentityDbContext hem de DbContext sınıfından kalıtım alarak Identity ve EntityFrameworkCore kütüphanelerini kullanabilmemizi sağlar.

public class EShopDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
{
  public EShopDbContext(DbContextOptions options) : base(options)
  {

  }

  public DbSet<Category> Categories { get; set; }
  public DbSet<Product> Products { get; set; }
  public DbSet<ProductCategory> ProductCategories { get; set; }

  protected override void OnModelCreating(ModelBuilder builder)
  {
    builder.Entity<ProductCategory>(entity =>
    {
      entity.HasKey(pk => new { pk.ProductId, pk.CategoryId });
      // Product bire çok ilişki.
      entity.HasOne(pc => pc.Product)
        .WithMany(p => p.ProductCategories)
        .HasForeignKey(fk => fk.ProductId);
      // Category bire çok ilişki. 
      entity.HasOne(pc => pc.Category)
        .WithMany(c => c.ProductCategories)
        .HasForeignKey(fk => fk.CategoryId);
      // HasData ile veri ekleme
      entity.HasData(
          // Elektronik kategorisi (ID = 1)
          new { ProductId = 1, CategoryId = 1 },
          new { ProductId = 2, CategoryId = 1 },
          new { ProductId = 3, CategoryId = 1 },
          new { ProductId = 4, CategoryId = 1 },
          new { ProductId = 5, CategoryId = 1 },
          new { ProductId = 51, CategoryId = 1 },
          new { ProductId = 52, CategoryId = 1 },
          new { ProductId = 54, CategoryId = 1 },
          new { ProductId = 55, CategoryId = 1 },

          // Moda kategorisi (ID = 2)
          new { ProductId = 6, CategoryId = 2 },
          new { ProductId = 7, CategoryId = 2 },
          new { ProductId = 8, CategoryId = 2 },
          new { ProductId = 9, CategoryId = 2 },
          new { ProductId = 10, CategoryId = 2 },
          new { ProductId = 56, CategoryId = 2 },
          new { ProductId = 57, CategoryId = 2 },
          new { ProductId = 58, CategoryId = 2 },
          new { ProductId = 59, CategoryId = 2 },
          new { ProductId = 60, CategoryId = 2 },

          // Ev Aletleri kategorisi (ID = 3)
          new { ProductId = 11, CategoryId = 3 },
          new { ProductId = 12, CategoryId = 3 },
          new { ProductId = 13, CategoryId = 3 },
          new { ProductId = 14, CategoryId = 3 },
          new { ProductId = 15, CategoryId = 3 },
          new { ProductId = 61, CategoryId = 3 },
          new { ProductId = 62, CategoryId = 3 },
          new { ProductId = 63, CategoryId = 3 },
          new { ProductId = 64, CategoryId = 3 },
          new { ProductId = 65, CategoryId = 3 },

          // Kitap kategorisi (ID = 4)
          new { ProductId = 16, CategoryId = 4 },
          new { ProductId = 17, CategoryId = 4 },
          new { ProductId = 18, CategoryId = 4 },
          new { ProductId = 19, CategoryId = 4 },
          new { ProductId = 20, CategoryId = 4 },
          new { ProductId = 66, CategoryId = 4 },
          new { ProductId = 67, CategoryId = 4 },
          new { ProductId = 68, CategoryId = 4 },
          new { ProductId = 69, CategoryId = 4 },
          new { ProductId = 70, CategoryId = 4 },

          // Oyuncak kategorisi (ID = 5)
          new { ProductId = 21, CategoryId = 5 },
          new { ProductId = 22, CategoryId = 5 },
          new { ProductId = 23, CategoryId = 5 },
          new { ProductId = 24, CategoryId = 5 },
          new { ProductId = 25, CategoryId = 5 },
          new { ProductId = 71, CategoryId = 5 },
          new { ProductId = 72, CategoryId = 5 },
          new { ProductId = 73, CategoryId = 5 },
          new { ProductId = 74, CategoryId = 5 },
          new { ProductId = 75, CategoryId = 5 },

          // Spor Malzemeleri kategorisi (ID = 6)
          new { ProductId = 26, CategoryId = 6 },
          new { ProductId = 27, CategoryId = 6 },
          new { ProductId = 28, CategoryId = 6 },
          new { ProductId = 29, CategoryId = 6 },
          new { ProductId = 30, CategoryId = 6 },
          new { ProductId = 76, CategoryId = 6 },
          new { ProductId = 77, CategoryId = 6 },
          new { ProductId = 78, CategoryId = 6 },
          new { ProductId = 79, CategoryId = 6 },
          new { ProductId = 80, CategoryId = 6 },

          // Kozmetik kategorisi (ID = 7)
          new { ProductId = 31, CategoryId = 7 },
          new { ProductId = 32, CategoryId = 7 },
          new { ProductId = 33, CategoryId = 7 },
          new { ProductId = 34, CategoryId = 7 },
          new { ProductId = 35, CategoryId = 7 },
          new { ProductId = 81, CategoryId = 7 },
          new { ProductId = 82, CategoryId = 7 },
          new { ProductId = 83, CategoryId = 7 },
          new { ProductId = 84, CategoryId = 7 },
          new { ProductId = 85, CategoryId = 7 },

          // Gıda kategorisi (ID = 8)
          new { ProductId = 36, CategoryId = 8 },
          new { ProductId = 37, CategoryId = 8 },
          new { ProductId = 38, CategoryId = 8 },
          new { ProductId = 39, CategoryId = 8 },
          new { ProductId = 40, CategoryId = 8 },
          new { ProductId = 86, CategoryId = 8 },
          new { ProductId = 87, CategoryId = 8 },
          new { ProductId = 88, CategoryId = 8 },
          new { ProductId = 89, CategoryId = 8 },
          new { ProductId = 90, CategoryId = 8 },

          // Oyun kategorisi (ID = 9)
          new { ProductId = 41, CategoryId = 9 },
          new { ProductId = 42, CategoryId = 9 },
          new { ProductId = 43, CategoryId = 9 },
          new { ProductId = 44, CategoryId = 9 },
          new { ProductId = 45, CategoryId = 9 },
          new { ProductId = 91, CategoryId = 9 },
          new { ProductId = 92, CategoryId = 9 },
          new { ProductId = 93, CategoryId = 9 },
          new { ProductId = 94, CategoryId = 9 },
          new { ProductId = 95, CategoryId = 9 },

          // Otomotiv kategorisi (ID = 10)
          new { ProductId = 46, CategoryId = 10 },
          new { ProductId = 47, CategoryId = 10 },
          new { ProductId = 48, CategoryId = 10 },
          new { ProductId = 49, CategoryId = 10 },
          new { ProductId = 50, CategoryId = 10 },
          new { ProductId = 96, CategoryId = 10 },
          new { ProductId = 97, CategoryId = 10 },
          new { ProductId = 98, CategoryId = 10 },
          new { ProductId = 99, CategoryId = 10 },
          new { ProductId = 100, CategoryId = 10 }
      );
    }); // Operasyonel veritabanı için birincil anahtar belirleme

    builder.Entity<Category>(entity =>
    {
      entity.HasKey(pk => pk.Id);
      entity.Property(p => p.Id).ValueGeneratedOnAdd(); // Birer birer artan değerler. 1,2,3,4...
      entity.Property(p => p.Name).HasMaxLength(100).IsRequired(); // Name değişkenini zorunlu hale getirir ve maksimum uzunluğunu 100 karakter olarak belirler.
      entity.Property(p => p.Description).HasMaxLength(500);
      entity.HasData(
        new Category("Elektronik", "elektronik.jpg")
        {
          Id = 1,
          Name = "Elektronik", // Eksik olan Name özelliği eklendi
          Description = "Akıllı telefonlar, dizüstü bilgisayarlar ve kameralar gibi cihazlar.",
          IsActive = true,
          IsDeleted = false,
          CreatedDate = DateTime.UtcNow,
          UpdatedDate = DateTime.UtcNow
        },
        new Category("Moda", "moda.jpg")
        {
          Id = 2,
          Name = "Moda", // Eksik olan Name özelliği eklendi
          Description = "Kadın ve erkekler için en trend kıyafetler ve aksesuarlar.",
          IsActive = true,
          IsDeleted = false,
          CreatedDate = DateTime.UtcNow,
          UpdatedDate = DateTime.UtcNow
        },
        new Category("Ev Aletleri", "ev_aletleri.jpg")
        {
          Id = 3,
          Name = "Ev Aletleri", // Eksik olan Name özelliği eklendi
          Description = "Buzdolabı ve çamaşır makinesi gibi temel ev aletleri.",
          IsActive = true,
          IsDeleted = false,
          CreatedDate = DateTime.UtcNow,
          UpdatedDate = DateTime.UtcNow
        },
        new Category("Kitaplar", "kitaplar.jpg")
        {
          Id = 4,
          Name = "Kitaplar", // Eksik olan Name özelliği eklendi
          Description = "Birbirinden farklı tür ve yazarlardan geniş bir kitap koleksiyonu.",
          IsActive = false, // Pasif durumda
          IsDeleted = false,
          CreatedDate = DateTime.UtcNow,
          UpdatedDate = DateTime.UtcNow
        },
        new Category("Oyuncaklar", "oyuncaklar.jpg")
        {
          Id = 5,
          Name = "Oyuncaklar", // Eksik olan Name özelliği eklendi
          Description = "Her yaştan çocuklar için eğitici ve eğlenceli oyuncaklar.",
          IsActive = true,
          IsDeleted = false,
          CreatedDate = DateTime.UtcNow,
          UpdatedDate = DateTime.UtcNow
        },
        new Category("Spor Malzemeleri", "spor_malzemeleri.jpg")
        {
          Id = 6,
          Name = "Spor Malzemeleri", // Eksik olan Name özelliği eklendi
          Description = "Spor ve açık hava aktiviteleri için ekipmanlar.",
          IsActive = false, // Pasif durumda
          IsDeleted = false,
          CreatedDate = DateTime.UtcNow,
          UpdatedDate = DateTime.UtcNow
        },
        new Category("Kozmetik Ürünleri", "kozmetik_urunleri.jpg")
        {
          Id = 7,
          Name = "Kozmetik Ürünleri", // Eksik olan Name özelliği eklendi
          Description = "Makyaj malzemeleri, cilt bakım ürünleri ve güzellik gereksinimleri.",
          IsActive = true,
          IsDeleted = true, // Silinmiş durumda
          CreatedDate = DateTime.UtcNow,
          UpdatedDate = DateTime.UtcNow
        },
        new Category("Gıda ve Market", "gida_market.jpg")
        {
          Id = 8,
          Name = "Gıda ve Market", // Eksik olan Name özelliği eklendi
          Description = "Günlük ihtiyaçlar ve temel market ürünleri.",
          IsActive = true,
          IsDeleted = false,
          CreatedDate = DateTime.UtcNow,
          UpdatedDate = DateTime.UtcNow
        },
        new Category("Oyun ve Eğlence", "oyun_eglence.jpg")
        {
          Id = 9,
          Name = "Oyun ve Eğlence", // Eksik olan Name özelliği eklendi
          Description = "Oyun konsolları, video oyunları ve aksesuarlar.",
          IsActive = true,
          IsDeleted = true, // Silinmiş durumda
          CreatedDate = DateTime.UtcNow,
          UpdatedDate = DateTime.UtcNow
        },
        new Category("Otomotiv", "otomotiv.jpg")
        {
          Id = 10,
          Name = "Otomotiv", // Eksik olan Name özelliği eklendi
          Description = "Araç aksesuarları, bakım ürünleri ve yedek parçalar.",
          IsActive = true,
          IsDeleted = false,
          CreatedDate = DateTime.UtcNow,
          UpdatedDate = DateTime.UtcNow
        }
    );
    });

    builder.Entity<Product>(entity =>
    {
      entity.HasKey(pk => pk.Id);
      entity.Property(p => p.Id).ValueGeneratedOnAdd(); // Birer birer artan değerler. 1,2,3,4...
      entity.Property(p => p.Name).HasMaxLength(100).IsRequired(); // Name değişkenini zorunlu hale getirir ve maksimum uzunluğunu 100 karakter olarak belirler.
      entity.Property(p => p.Properties).HasMaxLength(500);// Properties değişkeninin maksimum uzunluğunu 500 karakter olarak belirler.
      entity.Property(p => p.Price).HasColumnType("decimal(10,2)").IsRequired(); // Price değişkeninin veritabanında decimal(10,2) olarak tanımlanmasını sağlar.
      entity.Property(p => p.ImageUrl).HasMaxLength(500);// ImageUrl değişkeninin maksimum uzunluğunu 500 karakter olarak belirler.
      entity.HasData(
        new Product("Elektronik Ürün 1", "4K çözünürlüklü televizyon.", 1500m, "elektronik1.jpg")
        {
          Id = 1,
          IsActive = true,
          IsDeleted = false,
          CreatedDate = DateTime.UtcNow,
          UpdatedDate = DateTime.UtcNow
        },
new Product("Elektronik Ürün 2", "Kablosuz kulaklık.", 350m, "elektronik2.jpg")
{
  Id = 2,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Elektronik Ürün 3", "Bluetooth hoparlör.", 300m, "elektronik3.jpg")
{
  Id = 3,
  IsActive = false,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Elektronik Ürün 4", "Taşınabilir şarj cihazı.", 200m, "elektronik4.jpg")
{
  Id = 4,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Elektronik Ürün 5", "Akıllı saat.", 1200m, "elektronik5.jpg")
{
  Id = 5,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Moda Ürün 6", "Pamuklu tişört.", 100m, "moda1.jpg")
{
  Id = 6,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Moda Ürün 7", "Kot pantolon.", 250m, "moda2.jpg")
{
  Id = 7,
  IsActive = true,
  IsDeleted = true,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Moda Ürün 8", "Şık ceket.", 450m, "moda3.jpg")
{
  Id = 8,
  IsActive = false,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Moda Ürün 9", "Kadın spor ayakkabı.", 400m, "moda4.jpg")
{
  Id = 9,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Moda Ürün 10", "Rahat spor taytı.", 150m, "moda5.jpg")
{
  Id = 10,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Ev Aletleri Ürün 11", "Elektrikli süpürge.", 1200m, "ev_aletleri1.jpg")
{
  Id = 11,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Ev Aletleri Ürün 12", "Çamaşır makinesi.", 2500m, "ev_aletleri2.jpg")
{
  Id = 12,
  IsActive = false,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Ev Aletleri Ürün 13", "Mikrodalga fırın.", 800m, "ev_aletleri3.jpg")
{
  Id = 13,
  IsActive = true,
  IsDeleted = true,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Ev Aletleri Ürün 14", "Buzdolabı.", 3000m, "ev_aletleri4.jpg")
{
  Id = 14,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Ev Aletleri Ürün 15", "Hava temizleyici.", 900m, "ev_aletleri5.jpg")
{
  Id = 15,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Kitap Ürün 16", "Tarihi roman.", 90m, "kitap1.jpg")
{
  Id = 16,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Kitap Ürün 17", "Bilim kurgu romanı.", 120m, "kitap2.jpg")
{
  Id = 17,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Kitap Ürün 18", "Kişisel gelişim kitabı.", 75m, "kitap3.jpg")
{
  Id = 18,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Kitap Ürün 19", "Popüler bilim kitabı.", 130m, "kitap4.jpg")
{
  Id = 19,
  IsActive = false,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Kitap Ürün 20", "Fantastik roman.", 100m, "kitap5.jpg")
{
  Id = 20,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Oyuncak Ürün 21", "Ahşap yapboz.", 50m, "oyuncak1.jpg")
{
  Id = 21,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Oyuncak Ürün 22", "Peluş oyuncak.", 150m, "oyuncak2.jpg")
{
  Id = 22,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Oyuncak Ürün 23", "LEGO seti.", 300m, "oyuncak3.jpg")
{
  Id = 23,
  IsActive = false,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Oyuncak Ürün 24", "Eğitici oyuncak.", 120m, "oyuncak4.jpg")
{
  Id = 24,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Oyuncak Ürün 25", "Uzaktan kumandalı araba.", 500m, "oyuncak5.jpg")
{
  Id = 25,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Spor Malzemesi Ürün 26", "Fitness matı, kaymaz yüzey.", 250m, "spor1.jpg")
{
  Id = 26,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Spor Malzemesi Ürün 27", "Dumbell seti, 10kg.", 500m, "spor2.jpg")
{
  Id = 27,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Spor Malzemesi Ürün 28", "Koşu bandı, elektronik ekran.", 4000m, "spor3.jpg")
{
  Id = 28,
  IsActive = false,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Spor Malzemesi Ürün 29", "Yoga kemeri, dayanıklı malzeme.", 150m, "spor4.jpg")
{
  Id = 29,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Spor Malzemesi Ürün 30", "Pilates topu, anti-patlama özelliği.", 180m, "spor5.jpg")
{
  Id = 30,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Kozmetik Ürün 31", "Doğal içerikli yüz kremi.", 120m, "kozmetik1.jpg")
{
  Id = 31,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Kozmetik Ürün 32", "Mat ruj, uzun süre kalıcı.", 90m, "kozmetik2.jpg")
{
  Id = 32,
  IsActive = false,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Kozmetik Ürün 33", "Nemlendirici el kremi.", 50m, "kozmetik3.jpg")
{
  Id = 33,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Kozmetik Ürün 34", "Saç bakım yağı, doğal içerik.", 75m, "kozmetik4.jpg")
{
  Id = 34,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Kozmetik Ürün 35", "Göz altı kapatıcısı, hafif formül.", 130m, "kozmetik5.jpg")
{
  Id = 35,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Gıda Ürün 36", "Organik bal, 500g.", 120m, "gida1.jpg")
{
  Id = 36,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Gıda Ürün 37", "Sızma zeytinyağı, 1L.", 150m, "gida2.jpg")
{
  Id = 37,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Gıda Ürün 38", "Tam buğday ekmeği, 800g.", 15m, "gida3.jpg")
{
  Id = 38,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Gıda Ürün 39", "Doğal çiğ fındık, 250g.", 75m, "gida4.jpg")
{
  Id = 39,
  IsActive = true,
  IsDeleted = true,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Gıda Ürün 40", "Filtre kahve, 1kg.", 80m, "gida5.jpg")
{
  Id = 40,
  IsActive = false,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Otomotiv Ürün 41", "Araç içi telefon tutucu.", 120m, "otomotiv1.jpg")
{
  Id = 41,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Otomotiv Ürün 42", "Lastik tamir spreyi.", 60m, "otomotiv2.jpg")
{
  Id = 42,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Otomotiv Ürün 43", "Araç içi hava temizleyici.", 200m, "otomotiv3.jpg")
{
  Id = 43,
  IsActive = true,
  IsDeleted = true,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Otomotiv Ürün 44", "Bagaj düzenleyici.", 150m, "otomotiv4.jpg")
{
  Id = 44,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Otomotiv Ürün 45", "Akıllı araç kamerası.", 800m, "otomotiv5.jpg")
{
  Id = 45,
  IsActive = false,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Oyun Ürün 46", "Strateji oyunu, 2-4 kişi için.", 250m, "oyun1.jpg")
{
  Id = 46,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Oyun Ürün 47", "PlayStation 5 oyun konsolu.", 12000m, "oyun2.jpg")
{
  Id = 47,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Oyun Ürün 48", "Bilgisayar oyunu, macera türü.", 300m, "oyun3.jpg")
{
  Id = 48,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Oyun Ürün 49", "Monopoly masa oyunu.", 200m, "oyun4.jpg")
{
  Id = 49,
  IsActive = false,
  IsDeleted = true,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Oyun Ürün 50", "VR gözlük seti.", 5000m, "oyun5.jpg")
{
  Id = 50,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Elektronik Ürün 51", "Dizüstü bilgisayar, i7 işlemci.", 15000m, "elektronik6.jpg")
{
  Id = 51,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Elektronik Ürün 52", "Akıllı telefon, 128GB.", 8000m, "elektronik7.jpg")
{
  Id = 52,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Elektronik Ürün 53", "Kablosuz klavye ve mouse seti.", 600m, "elektronik8.jpg")
{
  Id = 53,
  IsActive = false,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Elektronik Ürün 54", "4TB harici disk.", 1500m, "elektronik9.jpg")
{
  Id = 54,
  IsActive = true,
  IsDeleted = true,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Elektronik Ürün 55", "Grafik tableti.", 2500m, "elektronik10.jpg")
{
  Id = 55,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Moda Ürün 56", "Kadın kaban, yün karışımlı.", 1000m, "moda6.jpg")
{
  Id = 56,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Moda Ürün 57", "Erkek deri cüzdan.", 350m, "moda7.jpg")
{
  Id = 57,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Moda Ürün 58", "Unisex şapka, pamuklu.", 100m, "moda8.jpg")
{
  Id = 58,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Moda Ürün 59", "Kadın spor ceketi.", 700m, "moda9.jpg")
{
  Id = 59,
  IsActive = false,
  IsDeleted = true,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Moda Ürün 60", "Erkek klasik ayakkabı.", 1200m, "moda10.jpg")
{
  Id = 60,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Ev Aletleri Ürün 61", "Kapsül kahve makinesi.", 1500m, "ev_aletleri6.jpg")
{
  Id = 61,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Ev Aletleri Ürün 62", "Mini fırın.", 900m, "ev_aletleri7.jpg")
{
  Id = 62,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Ev Aletleri Ürün 63", "Mutfak robotu, 15 fonksiyonlu.", 2000m, "ev_aletleri8.jpg")
{
  Id = 63,
  IsActive = false,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Ev Aletleri Ürün 64", "Su arıtma cihazı.", 2500m, "ev_aletleri9.jpg")
{
  Id = 64,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Ev Aletleri Ürün 65", "Mikser, çok fonksiyonlu.", 800m, "ev_aletleri10.jpg")
{
  Id = 65,
  IsActive = true,
  IsDeleted = true,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Kitap Ürün 66", "Psikoloji kitabı.", 90m, "kitap6.jpg")
{
  Id = 66,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Kitap Ürün 67", "Klasik roman, dünya edebiyatı.", 75m, "kitap7.jpg")
{
  Id = 67,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Kitap Ürün 68", "Çocuk kitabı, resimli hikaye.", 50m, "kitap8.jpg")
{
  Id = 68,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Kitap Ürün 69", "Şiir kitabı.", 45m, "kitap9.jpg")
{
  Id = 69,
  IsActive = false,
  IsDeleted = true,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Kitap Ürün 70", "Tarih kitabı, araştırma eseri.", 120m, "kitap10.jpg")
{
  Id = 70,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Oyuncak Ürün 71", "Zeka geliştiren kart oyunu.", 60m, "oyuncak6.jpg")
{
  Id = 71,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Oyuncak Ürün 72", "Yumuşak top seti.", 90m, "oyuncak7.jpg")
{
  Id = 72,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Oyuncak Ürün 73", "Manyetik yapboz seti.", 140m, "oyuncak8.jpg")
{
  Id = 73,
  IsActive = false,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Oyuncak Ürün 74", "İnşaat araçları seti.", 200m, "oyuncak9.jpg")
{
  Id = 74,
  IsActive = true,
  IsDeleted = true,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Oyuncak Ürün 75", "Uzaktan kumandalı helikopter.", 800m, "oyuncak10.jpg")
{
  Id = 75,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Oyun Ürün 76", "Denge tahtası.", 300m, "spor6.jpg")
{
  Id = 76,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Oyun Ürün 77", "Yüzme gözlüğü, UV korumalı.", 180m, "spor7.jpg")
{
  Id = 77,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Oyun Ürün 78", "Basketbol topu, dayanıklı malzeme.", 220m, "spor8.jpg")
{
  Id = 78,
  IsActive = false,
  IsDeleted = true,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Oyun Ürün 79", "Koşu ayakkabısı.", 700m, "spor9.jpg")
{
  Id = 79,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Oyun Ürün 80", "Spor çantası, hafif ve geniş.", 250m, "spor10.jpg")
{
  Id = 80,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Kozmetik Ürün 81", "Parfüm, ferah koku.", 400m, "kozmetik6.jpg")
{
  Id = 81,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Kozmetik Ürün 82", "Cilt temizleme jeli.", 70m, "kozmetik7.jpg")
{
  Id = 82,
  IsActive = false,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Kozmetik Ürün 83", "Doğal şampuan, organik içerik.", 90m, "kozmetik8.jpg")
{
  Id = 83,
  IsActive = true,
  IsDeleted = true,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Kozmetik Ürün 84", "Tırnak bakım seti.", 120m, "kozmetik9.jpg")
{
  Id = 84,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Kozmetik Ürün 85", "Vücut losyonu, yoğun nemlendirici.", 100m, "kozmetik10.jpg")
{
  Id = 85,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Gıda Ürün 86", "Süt, yarım yağlı, 1L.", 25m, "gida6.jpg")
{
  Id = 86,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Gıda Ürün 87", "Organik muz, 1kg.", 30m, "gida7.jpg")
{
  Id = 87,
  IsActive = false,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Gıda Ürün 88", "Çikolata, sütlü, 100g.", 15m, "gida8.jpg")
{
  Id = 88,
  IsActive = true,
  IsDeleted = true,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Gıda Ürün 89", "Tam buğday makarna, 500g.", 20m, "gida9.jpg")
{
  Id = 89,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Gıda Ürün 90", "Organik yumurta, 10'lu.", 40m, "gida10.jpg")
{
  Id = 90,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Otomotiv Ürün 91", "Cam suyu, antifrizli.", 40m, "otomotiv6.jpg")
{
  Id = 91,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Otomotiv Ürün 92", "Araç lastik basınç ölçer.", 150m, "otomotiv7.jpg")
{
  Id = 92,
  IsActive = false,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Otomotiv Ürün 93", "Direksiyon kılıfı.", 120m, "otomotiv8.jpg")
{
  Id = 93,
  IsActive = true,
  IsDeleted = true,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Otomotiv Ürün 94", "Koltuk düzenleyici.", 180m, "otomotiv9.jpg")
{
  Id = 94,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Otomotiv Ürün 95", "Bagaj örtüsü, su geçirmez.", 300m, "otomotiv10.jpg")
{
  Id = 95,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Oyun Ürün 96", "Satranç seti, ahşap malzeme.", 250m, "oyun6.jpg")
{
  Id = 96,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Oyun Ürün 97", "PC oyun kolu, kablosuz.", 600m, "oyun7.jpg")
{
  Id = 97,
  IsActive = false,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Oyun Ürün 98", "Puzzle, 1000 parça.", 150m, "oyun8.jpg")
{
  Id = 98,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Oyun Ürün 99", "Çocuk masası ve sandalye seti.", 1200m, "oyun9.jpg")
{
  Id = 99,
  IsActive = true,
  IsDeleted = true,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
},
new Product("Oyun Ürün 100", "Eğitici robot seti.", 5000m, "oyun10.jpg")
{
  Id = 100,
  IsActive = true,
  IsDeleted = false,
  CreatedDate = DateTime.UtcNow,
  UpdatedDate = DateTime.UtcNow
}
      );
    });

    base.OnModelCreating(builder);
  }
}
