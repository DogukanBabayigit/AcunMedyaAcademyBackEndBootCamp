namespace dateTime_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen bir tarih giriniz:");
        string tarihstr = Console.ReadLine();

        if (DateTime.TryParse(tarihstr, out DateTime tarih))
        {
            DayOfWeek gun = tarih.DayOfWeek;
            System.Console.WriteLine($"Girilen Tarihin Günü: {gun}");
        }
    }
}
