namespace _07_Store_Product_Management;

public class Product
{

    public string Name { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; private set; }

    public Product(string name, decimal price, int stockQuantity)
    {
        Name = name;
        Price = price;
        StockQuantity = stockQuantity;
    }

    public bool CheckStock(int quantity)
    {
        return StockQuantity >= quantity;
    }

    public void UpdateStock(int quantity)
    {
        StockQuantity += quantity;
        Console.WriteLine($"{Name} ürününün yeni stok miktarı: {StockQuantity}");
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Ürün Adı: {Name}, Fiyat: {Price:C}, Stok Miktarı: {StockQuantity}");
    }
}

public class FoodProduct : Product
{
    public DateTime ExpirationDate { get; set; }

    public FoodProduct(string name, decimal price, int stockQuantity, DateTime expirationDate)
        : base(name, price, stockQuantity)
    {
        ExpirationDate = expirationDate;
    }

    public bool IsExpired()
    {
        return DateTime.Now > ExpirationDate;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Son Kullanma Tarihi: {ExpirationDate.ToString("dd/MM/yyyy")}, Durum: {(IsExpired() ? "Süresi Geçmiş" : "Geçerli")}");
    }
}

public class ElectronicProduct : Product
{
    public string WarrantyPeriod { get; set; }
    public ElectronicProduct(string name, decimal price, int stockQuantity, string warrantyPeriod)
        : base(name, price, stockQuantity)
    {
        WarrantyPeriod = warrantyPeriod;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Garanti Süresi: {WarrantyPeriod}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        FoodProduct apple = new FoodProduct("Elma", 1.5m, 100, new DateTime(2024, 12, 31));
        ElectronicProduct phone = new ElectronicProduct("Akıllı Telefon", 5000m, 20, "2 Yıl");

        apple.DisplayInfo();
        Console.WriteLine();
        phone.DisplayInfo();

        Console.WriteLine();
        if (apple.CheckStock(10))
        {
            Console.WriteLine("Elma stokta mevcut.");
        }
        else
        {
            Console.WriteLine("Elma stokta yok.");
        }

        // Stok güncelleme
        apple.UpdateStock(-10); // Stoktan 10 azaltma
        phone.UpdateStock(5);   // Stoka 5 ekleme
    }
}