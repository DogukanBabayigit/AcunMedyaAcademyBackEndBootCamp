using System.Globalization;

namespace dateTime_8;

class Program
{
    static void Main(string[] args)
    {
        DateTime suan = DateTime.Now;

        string ayAdi = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(suan.Month);

        System.Console.Write($"Şuan ki ay : {ayAdi}");
    }
}
