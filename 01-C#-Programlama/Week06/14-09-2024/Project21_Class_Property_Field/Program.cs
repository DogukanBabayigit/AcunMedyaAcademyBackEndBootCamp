using System.Data.Common;

namespace Project21_Class_Property_Field;
/* class Product
{
    int id;
    string name;
    decimal price;
    bool isActive; */

//Class içindeki bilgileri kontrollü bir biçimde açılmaısnı sağlayan yapılara Property diyoruz. Yaptığımız bu işleme "Kapsülleme"diyoruz.(Encapsulation=Kapsülleme                                                               )
/* public string Name
{
    get
    {
        string result = name.Substring(0, 3).ToUpper();
        return result; //Veriyi büyük harflerle yazarak kaydediyor.
    }
    set
    {
        name = value; //Value: dışarıdan aldığımız değerin yazılmasını sağlar.//
    }
} */

/* public decimal Price
{
    get
    {
        return price;
    }
    set
    {
        if (value < 0)
        {
            price = 0;
        }
        else
            price = value;

        //Bu işlemde sıfırdan küçük değer girememizi engeller. Girildiği takdirde 0 olarak ekrana yazar.

        // tenary if hali
        //price = value < 0 ? :value; 
    }
} */
//}
class Product
{
    //propfull snippet
    //private int id;
    //private int Id
    /* {
        get {return id;}
        set {id = value;}
    } */

    public int Id { get; set; }

    public string Name { get; set; } = "";//null olabaileceğini belirtmek için ? koyabiliriz. Int ve türevi null olamaz.""; var ama yok anlamında kullanabilir.

    public string? Description { get; set; }

    public required string Notes { get; set; }//Required ile bu class kullanıldğında notes değişkenin boş bırakılmasının önüne geçilmesini sağlar.

    public decimal Price { get; set; }

    public bool IsActive { get; set; }
}

class Student
{
    public Student()
    {
        System.Console.WriteLine($"{DateTime.Now} zamanında yeni bir Student oluşturuldu...");
    }
    public Student(int studentNumber)
    {
        StudentNumber = studentNumber;
        System.Console.WriteLine($"{DateTime.Now} zamanında yeni bir Student oluşturuldu...");

    }
    public int StudentNumber { get; set; }
    public String FirstName { get; set; }

    public String LasName { get; set; }
    public byte Age { get; set; }

    public bool IsActive { get; set; }
}

class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Category(int id)
    {
        Id = id;
    }

    public Category(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public Category(int id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }

}



class Program
{
    static void Main(string[] args)
    {
        Category c1 = new Category(48);
        Category c2 = new Category(52, "Doğukan");
        Category c3 = new Category(52, "Doğukan", "Yeni Öğrenci");










        // Product product1 = new() { Notes = "Bişeyler" };
        // product1.Id = 5;
        // product1.Price = 500;
        // product1.Name = "Macbook M2 Air";
        // //System.Console.WriteLine($"{product1.Id}. {product1.Name} : {product1.Price} : {product1.Notes}");


        /* Product product1 = new Product();
        product1.Name = "iPhone 14"; // Yukarıdad bulunan set{} çalıştıracak kod. Bilgiyi name=value; atar.
        System.Console.WriteLine(product1.Name); //Name içinde yazanı ekrana getiriyor. get{} çalıştırmak için.
        product1.Price = 60000; // 0'dan küçük değer girildiğinde ekrana 0 olarak yazacaktır.
        System.Console.WriteLine(product1.Price); */
    }
}
