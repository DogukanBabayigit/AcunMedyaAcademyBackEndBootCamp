namespace if_else_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1.Kenarini giriniz: ");
        double kenar1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("2.Kenarini giriniz: ");
        double kenar2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("3.Kenarini giriniz: ");
        double kenar3 = Convert.ToDouble(Console.ReadLine());
        bool ucgenMi = (kenar1 + kenar2 > kenar3) && (kenar1 + kenar3 > kenar2) && (kenar2 + kenar3 > kenar1);

        if (ucgenMi)
        {
            System.Console.WriteLine("Bu kenar uzunluklari ile Ucgen olusturulabilir.");
        }
        else
            System.Console.WriteLine("Bu kenar uzunluklari ile Ucgen olusturulamaz.");
    }
}
