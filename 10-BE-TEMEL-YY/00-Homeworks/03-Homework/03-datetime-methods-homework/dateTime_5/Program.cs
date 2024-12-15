namespace dateTime_5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir Tarih Giriniz: ");
        string tarihStr = Console.ReadLine();

        if (DateTime.TryParse(tarihStr, out DateTime Tarih))
        {
            DateTime yilinBaslangici = new DateTime(Tarih.Year, 1, 1);
            TimeSpan fark = Tarih - yilinBaslangici;

            int gunFarki = fark.Days + 1;

            System.Console.WriteLine($"{Tarih} tarihi, {Tarih.Year} yılının {gunFarki}. günüdür.");
        }
    }
}
