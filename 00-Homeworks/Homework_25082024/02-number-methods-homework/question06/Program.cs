namespace question06;

class Program
{
    static void Main(string[] args)
    // Math.Sin
    {
        Console.WriteLine("Bir sayi giriniz: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        double sinan = Math.Sin(sayi1);

        System.Console.WriteLine("Sayinin Sinus Degeri : " + sinan);
    }
}
