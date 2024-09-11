using System.Globalization;
using System.Xml;

namespace Project17_MethodOverloading;

class Program
{
    // Aymı method gerektiğinde kullanılabilir fakat veri eklenmediği veya değişmediğinde hata verecektir.

    // static int Sum(int a, int b)
    // {
    //     return a + b;
    // }
    // static int Sum(int a, int b, int c)
    // {
    //     return a + b + c;
    // }
    // static int Sum(int a, int b, int c, int d)
    // {
    //     return a + b + c + d;
    // }

    // static void Greet(string name, byte age)
    // {
    //     System.Console.WriteLine($"Merhaba {age} yaşındaki {name}");
    // }

    /////////////////////////////////////////////////

    static string GetCoffee(string coffeeType, int quantitySugar = 0, bool withMilk = true)
    {
        string coffee = $"{coffeeType} kahve";
        coffee += quantitySugar > 0 ? $"{quantitySugar} sekerli," : " sekersiz,";
        if (withMilk)
        {
            coffee += " Sütlü";
        }
        else
            coffee += " Sütsüz";
        coffee += "\nKahveniz hazir. Afiyet Olsun:D";
        return coffee;
    }
    static void Main(string[] args)
    {

        System.Console.WriteLine(GetCoffee("Americano "));
        System.Console.WriteLine(GetCoffee("Americano ", 2));
        System.Console.WriteLine(GetCoffee("Americano ", 5, false));







        // Console.WriteLine(Sum(5, 7));
        // Console.WriteLine(Sum(5, 7, 8));
        // Console.WriteLine(Sum(5, 7, 8, 9));
        // Greet("Engin", 49);


    }
}
