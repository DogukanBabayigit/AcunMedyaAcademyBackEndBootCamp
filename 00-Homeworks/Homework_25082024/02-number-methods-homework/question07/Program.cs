namespace question07;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen derece cinsinden bir açı değeri giriniz:");
        double derece = Convert.ToDouble(Console.ReadLine());

        const double pi = Math.PI;

        double radyan = derece * (pi / 180);

        Console.WriteLine($"{derece} derece = {radyan:F2} radyan");
    }
}
