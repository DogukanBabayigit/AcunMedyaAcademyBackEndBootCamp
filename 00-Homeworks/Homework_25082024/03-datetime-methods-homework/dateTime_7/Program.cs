using System.Globalization;

namespace dateTime_7;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Lütfen bir tarih giriniz (dd/MM/yyyy formatında):");
        string tarihStr = Console.ReadLine();

        CultureInfo culture = new("tr-TR");

        if (DateTime.TryParseExact(tarihStr, "dd/MM/yyyy", culture, DateTimeStyles.None, out DateTime tarih))
        {
            System.Console.WriteLine("Girilen tarih: " + tarih.ToString());
            System.Console.WriteLine("Gün Adi: " + tarih.DayOfWeek);
        }
    }
}
