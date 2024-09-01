namespace question04;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir sayi girin: ");
        double sayi = Convert.ToDouble(Console.ReadLine());

        double karekok = Math.Sqrt(sayi);

        System.Console.WriteLine("Sayinin Karekökü: " + karekok);

    }
}
