namespace question08;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir sayi giriniz: ");
        string giris = Console.ReadLine();

        if (double.TryParse(giris, out double sayi))
        {
            double dogalLogaritma = Math.Log(sayi);

            System.Console.WriteLine($"Girilen Sayi logaritmasi : {dogalLogaritma}");
        }
        else
        {
            System.Console.WriteLine("Geçersiz bir değer. Lütfen tekrar deneyiniz");
        }
    }

}
