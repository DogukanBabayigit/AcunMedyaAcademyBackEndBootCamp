namespace question05;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Taban sayi giriniz: ");
        int tSayi = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Üst sayi giriniZ: ");
        int uSayi = int.Parse(Console.ReadLine());

        double result = Math.Pow(tSayi, uSayi);

        System.Console.WriteLine($" {tSayi}^{uSayi}= {result}");

    }
}
