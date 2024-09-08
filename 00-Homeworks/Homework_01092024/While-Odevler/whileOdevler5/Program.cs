namespace whileOdevler5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir pozitif tam sayi giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        int tersSayi = 0;

        while (sayi != 0)
        {
            int basamak = sayi % 10; // Sayının son basamağını al
            tersSayi = tersSayi * 10 + basamak; // Ters sayıyı oluştur
            sayi /= 10; // Sayıyı 10'a bölerek birler basamağını at
        }
        System.Console.WriteLine("Sayinin ters sayisi: " + tersSayi);
    }
}
