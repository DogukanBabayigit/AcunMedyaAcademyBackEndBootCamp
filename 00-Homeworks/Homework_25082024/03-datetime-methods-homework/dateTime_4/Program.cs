namespace dateTime_4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Baslangic tarihi giriniz: ");
        string baslangicTarihStr = Console.ReadLine();

        System.Console.WriteLine("Bitiş tarihi giriniz: ");
        string bitisTarihiStr = Console.ReadLine();

        if (DateTime.TryParse(baslangicTarihStr, out DateTime baslangicTarihi) && DateTime.TryParse(bitisTarihiStr, out DateTime bitisTarihi))
        {
            TimeSpan fark = bitisTarihi - baslangicTarihi;
            int gunFarki = fark.Days;
            System.Console.WriteLine("Iki tarih arasındaki fark: " + gunFarki + " MAŞALLAAAHH!!!");
        }
        else
            System.Console.WriteLine("Geçersiz Format. Geçerli Olacak Şekilde Giriniz!");
    }
}
