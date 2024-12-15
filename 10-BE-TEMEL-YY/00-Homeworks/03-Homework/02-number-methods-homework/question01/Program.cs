namespace question01;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ondalik Sayi Giriniz: ");
        double Sayi = Convert.ToDouble(Console.ReadLine());

        int roundNumber = (int)Math.Round(Sayi);

        System.Console.WriteLine("Yuvarlanan Sayi: " + roundNumber);
    }
}
