using System.Reflection.PortableExecutable;
using System.Xml.XPath;
using Microsoft.VisualBasic;

namespace Project12;
class Program
{
    static object Main(string[] args)

    {
        #region Do While
        // Kullanıcıdan alınan girişlerin sadece sayı olmasını , silme eylemini yapmasını ve sadece enter tuşuna basıldığında programı kapatmasını sağlayan program.

        /* ConsoleKeyInfo chr;
        string resultNumber = "";
        Console.Write("Bir sayi giriniz: ");

        do
        {
            chr = Console.ReadKey(true);
            if (char.IsDigit(chr.KeyChar))
            {
                resultNumber += chr.KeyChar.ToString();
                System.Console.Write(chr.KeyChar.ToString());
            }
            else
            {
                if (chr.Key == ConsoleKey.Backspace && resultNumber.Length > 0)
                {
                    resultNumber = resultNumber.Substring(0, resultNumber.Length - 1);
                    Console.Write("\b \b");
                }
            }

        } while (chr.Key != ConsoleKey.Enter); */

        #endregion

        #region Girilen sayının asal sayı mı değil mi tepsit eden ve ekrana yazdıran program.

        string answer;
        int number = default;

        do
        {
            bool isPrime = true;
            System.Console.WriteLine("Bir sayi giriniz: ");
            number = int.Parse(Console.ReadLine());
            if (number <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= number - 1; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            System.Console.WriteLine(isPrime ? "Asal" : "Asal Değil");
            System.Console.WriteLine("------------------------------");
            System.Console.WriteLine("Tekrar Denemek İster Misiniz ? (E/H)");
            answer = Console.ReadLine();

        } while (answer != "H");

        #endregion

        #region Asol Yes/No

        /* Console.Write("Bir sayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        bool asalMi = true;

        // 2'den başlayarak sayının kendisinden bir eksiğe kadar tüm sayılara bölünebilirlik kontrolü
        for (int i = 2; i < sayi - 1; i++)
        {
            if (sayi % i == 0)
            {
                asalMi = false;
                break;
            }
        }

        if (asalMi)
        {
            Console.WriteLine("{0} sayısı asaldır.", sayi);
        }
        else
        {
            Console.WriteLine("{0} sayısı asal değildir.", sayi);

        } */
        #endregion

        #region Girilen sayının asal sayı mı değil mi tepsit eden ve ekrana yazdıran program. /While veya Do While

        /* Console.WriteLine("Bir sayı giriniz: ");
        int sayi = int.Parse(Console.ReadLine());

        int bolen = 2;
        bool asalMi = true;

        while (bolen < sayi)
        {
            if (sayi % bolen == 0)
            {
                asalMi = false;
                break;
            }
            bolen++;
        }

        if (asalMi)
        {
            Console.WriteLine("{0} sayısı asaldır.", sayi);
        }
        else
        {
            Console.WriteLine("{0} sayısı asal değildir.", sayi); */

        #endregion

        #region Girilen sayının asal sayı mı değil mi tepsit eden ve asal sayıyı bulana kadar çalışan program.

        /* int sayi, i;
        bool asalMi;

        do
        {
            System.Console.Write("Bir Sayi Giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            asalMi = true;
            for (int i = 2; i <= Math.Sqrt(sayi); i++)
            {
                if (sayi % i == 0)
                {
                    asalMi = false;
                    break;
                }

                if (asalMi)
                {
                    System.Console.WriteLine(sayi + "sayi asaldir.");
                }
                else
                {
                    System.Console.WriteLine(sayi + "sayi asal dağeldir.");
                }
            }
        } while (!asalMi); */

        #endregion
    }

}