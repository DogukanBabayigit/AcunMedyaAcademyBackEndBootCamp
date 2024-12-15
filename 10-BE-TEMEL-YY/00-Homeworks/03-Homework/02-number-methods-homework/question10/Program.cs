namespace question10;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen yuvarlanacak sayıyı giriniz:");
        string sayiStr = Console.ReadLine();

        Console.WriteLine("Lütfen yuvarlama yapılacak ondalık basamak sayısını giriniz:");
        string basamakSayisiStr = Console.ReadLine();

        // Girilen değerleri double'a dönüştürme
        if (double.TryParse(sayiStr, out double sayi) && int.TryParse(basamakSayisiStr, out int basamakSayisi))
        {
            // Sayıyı belirtilen basamak sayısına göre yuvarlama
            double yuvarlanmisSayi = Math.Round(sayi, basamakSayisi);

            // Sonucu ekrana yazdırma
            Console.WriteLine("Yuvarlanmış sayı: " + yuvarlanmisSayi);
        }
        else
        {
            Console.WriteLine("Geçersiz giriş. Lütfen sayı giriniz.");
        }
    }
}
