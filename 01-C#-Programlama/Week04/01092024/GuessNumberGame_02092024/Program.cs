namespace GuessNumberGame_02092024;

class Program
{
    static void Main(string[] args)
    {
        int tahmin;
        string cevap = "";
        Random rnd = new();
        int sayi = rnd.Next(1, 101);
        int tahminHakki = 5;

        System.Console.WriteLine("Sayı tahmin oyununa hoş geldiniz!");
        System.Console.WriteLine("1 ile 100 arasında bir sayı tuttum.Tahmin etmeye çalışın.");

        do
        {
            Console.Write("Tahmininiz: ");
            tahmin = Convert.ToInt32(Console.ReadLine());

            tahminHakki--;
            if (tahmin == sayi)
            {
                System.Console.WriteLine("Tebrikler , Kazandınız!");
            }
            else if (tahmin < sayi)
            {
                System.Console.WriteLine("Daha Büyük Bir Sayi >Giriniz.");
            }
            else
            {
                System.Console.WriteLine("Daha Küçük Bir Sayi Giriniz. ");
            }
        } while (tahminHakki > 0 && sayi != tahmin);

        if (tahminHakki == 0)
        {
            Console.WriteLine($"Tahmin haklarınız bitti. Tuttuğum sayı: {sayi}");
        }

        System.Console.WriteLine("Tekrar Oynamak İster Misin? (evet/hayır)");

        if (cevap == "evet")
        {
            Main(args);
        }

        else
        {
            Console.WriteLine("Oyun sona erdi.");
        }

    }
}
