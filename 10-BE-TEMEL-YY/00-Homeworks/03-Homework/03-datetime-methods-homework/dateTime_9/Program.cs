using System.Globalization;

namespace dateTime_9;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("İlk tarih giriniz: ");
        string tarihStr1 = Console.ReadLine();

        System.Console.WriteLine("İkinci tarihi giriniz: ");
        string tarihStr2 = Console.ReadLine();

        CultureInfo culture = new("tr-TR");

        if (DateTime.TryParseExact(tarihStr1, "dd/MM/yyyy", culture, DateTimeStyles.None, out DateTime tarih1) && DateTime.TryParseExact(tarihStr2, "dd/MM/yyyy", culture, DateTimeStyles.None, out DateTime tarih2))
        {
            if (tarih1 > tarih2)
            {
                System.Console.WriteLine($"{tarihStr1} tarihi, {tarihStr2} tarihinden öncedir.");
            }
            else if (tarih1 < tarih2)
            {
                System.Console.WriteLine($"{tarihStr1} tarihi, {tarihStr2} tarihinden sonradir.");
            }
            else
                System.Console.WriteLine("İki tarih eşittir.");
        }
        else
        {
            System.Console.WriteLine("Geçersiz tarih formati.");
        }
    }
}
