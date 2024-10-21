namespace whlieOdevler1;

class Program
{
    static void Main(string[] args)
    {
        int sayi = 0;
        int toplam = 0;

        Console.WriteLine("Sayilar giriniz. Sona ermesi için sıfır giriniz: ");
        do
        {
            sayi = Convert.ToInt32(Console.ReadLine());
            toplam = toplam + sayi;
        } while (sayi != 0);

        System.Console.WriteLine("Girilen sayilarilarin toplami:" + toplam);
    }
}
