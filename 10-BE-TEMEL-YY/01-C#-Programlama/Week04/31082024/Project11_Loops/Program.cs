using System.Numerics;

namespace Project11_Loops;

class Program
{
    static void Main(string[] args)
    {
        #region For
        /*  for (int counter = 1; counter <= 5; counter = counter + 1 // counter++)
         {
             //Döngü Gövedi : Döngü içersinde tekrar tekrar çalıştırılmasını istediğimiz kodlar.
             // Geleneksel yöntem = index " i " kullanılır. Örnek aşağıda

             System.Console.WriteLine($"{counter}.Merhaba Dünya");

             i++ = i=i+1
             i=i+3 = i=+3
         } */

        /* for (int i = 1; i <= 5; i++)
        {
            //Döngü Gövedi : Döngü içersinde tekrar tekrar çalıştırılmasını istediğimiz kodlar.

            System.Console.WriteLine($"{i}.Merhaba Dünya");
        } */

        //Ekrana 1-10 arasındaki sayıları yazdıran programı hazırlayınız.
        /* string message = default;
        for (int i = 100; i <= 200; i++)
        {
            message = $"Sayi{i-99} : {i}";
            // message =$"Sayi{i % 100 +1} : {i}"; 2.Yol
            System.Console.WriteLine(message);
        } */

        /* for (int i = 0; i <= 10; i++)
        {
            if (i % 2 == 0)
            {
                System.Console.WriteLine(i);
            }
        } */

        // Kullanıcıdan 2 sayi alın bu iki sayi arasındaki çift sayıları ekrana yazdırın.

        /* System.Console.WriteLine("Alt Sınır Giriniz: ");
        int min = int.Parse(Console.ReadLine());

        min = min % 2 == 0 ? min : min - 1;

        System.Console.WriteLine("Üst Sınır Giriniz: ");
        int max = int.Parse(Console.ReadLine());

        for (int i = min; i <= max; i += 2)
        {
            System.Console.WriteLine(i);
        }
        */

        // Kullanıcın girdiği sayının faktoriyelini hesaplayan programı yazınız.

        /* System.Console.WriteLine("Faktoriyeli hesaplanacak sayiyi giriniz: ");
        int value = int.Parse(Console.ReadLine());
        int factorial = 1;

        for (int i = 2; i <= value; i++)
        {
            factorial *= i; //factorial=factorial*i;
        }

        System.Console.WriteLine($"{value}! = {factorial}"); */

        /* System.Console.WriteLine("Faktoriyeli hesaplanacak sayiyi giriniz: ");
        int value = int.Parse(Console.ReadLine());
        int factorial = value;

        for (int i = value -1; i > 1; i--)
        {
            factorial *= i; //factorial=factorial*i;
        }

        System.Console.WriteLine($"{value}! = {factorial}"); */

        #endregion

        #region While

        /*  int i = 1;
         while (i <= 5)
         {
             System.Console.WriteLine($"{i}/ Hello World");
             i++;
         } */

        /* int total = 0; // = 0 ;
        string input = "";

        while (input != "Exit") // != 'değilse'
        {
            System.Console.Write("Bir sayi giriniz(Cikis icin Exit): ");
            input = Console.ReadLine();

            if (int.TryParse(input, out int inputNumber))
            {
                total += inputNumber;
            }
            else if (input != "Exit")
            {
                System.Console.WriteLine("Geçerli bir değer giriniz. ");
            }

            System.Console.WriteLine($"Toplam : {total}"); */

        //Kullanıcıdan arka arkaya alınacak sayıları toplayan kodu yazınız. Ancak kullanıcın girdiği sayıların toplamı 100'den büyük veya eşit ise program sona erip toplamı ekrana yazsın

        /* int toplam = 0;
        int input = default;

        while (toplam <= 100)
        {
            System.Console.WriteLine("Sayilari giriniz: ");
            input = Convert.ToInt32(Console.ReadLine());

            if (input <= 100)
            {
                toplam += input;
            }
            else if (input >= 100)
            {
                System.Console.WriteLine("100'den büyük veya eşit");
            }

            System.Console.WriteLine($"Toplam : {toplam}"); */

        //Hocanın Çözümü 01/09/2024

        /*  int toplam = 0;
         while (toplam<=100)
         {
             System.Console.WriteLine("Bir sayi giriniz: ");
             int inputNumber = int.Parse(Console.ReadLine());
             toplam += inputNumber;
         }

         System.Console.WriteLine(toplam); */
    }

}

    #endregion
}

