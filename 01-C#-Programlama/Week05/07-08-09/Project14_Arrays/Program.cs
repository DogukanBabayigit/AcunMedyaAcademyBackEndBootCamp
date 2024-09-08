using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Net.WebSockets;

namespace Project14_Arrays;

class Program
{
    static void Main(string[] args)
    {
        #region ArrayExamp1
        /*  //[] indexer çoğu zaman sıra numarası belirlemek için kullanırlır.
        int[] numbers;
        numbers = new int[5];

        numbers[0] = 45;
        numbers[1] = 145;
        numbers[2] = 245;
        numbers[3] = 435;
        numbers[4] = 4555;

        for (int i = 0; i < 5; i++)
        {
            System.Console.WriteLine($"Dizinin {i + 1}.Eleman: {numbers[i]}");
        } */
        #endregion

        #region ArrayExamp2
        /* 
                int[] numbers = [49, 34, 90, 67, 44];

                for (int i = 0; i < 5; i++)
                {
                    System.Console.WriteLine($"Dizinin {i + 1}.Elemani: {numbers[i]}");
                } */
        #endregion

        #region ArrayExamp3
        /*  string[] studentNames = [
             "Ali",
             "Ayie",
             "Murat",
             "Irmak",
             "Sezen"
         ];

         for (int i = 0; i < studentNames.Length; i++)
         {
             System.Console.WriteLine(studentNames[i]);
         }

         for (int i = 0; i < studentNames.Length; i++)
         {
             studentNames[i] += " Canoğlu";
         }
         System.Console.Write("");
         System.Console.WriteLine("Değişmiş Hali: ");
         for (int i = 0; i < studentNames.Length; i++)
         {
             System.Console.WriteLine(studentNames[i]);
         } */
        #endregion

        #region ArraysExamp4
        /* string[] studentNames =
        ["Ali",
        "Ayie",
        "Murat",
        "Irmak",
        "Sezen"
        ];

        foreach (string student in studentNames)
        {
            System.Console.WriteLine(student);
        } */
        #endregion

        #region ArraysExamp5

        /*   int[] prices = [40, 50, 60, 70, 80];
          int newprices = 0;

          //price dizisinin içinde fiyatlara %10 zamn gelmiştir. Zamli fiyatları içerecek şekilde prices dizisini güncelleyerek ekrana yaznıız.

          for (int i = 0; i < prices.Length; i++)
          {

              newprices = prices[i] / 10;
              prices[i] += newprices;
              System.Console.WriteLine(prices[i]);

              //Hocanın yazdığı: prices[i]=(int)(prices[i]*1.1)

          } */

        #endregion

        #region Examp.
        //a=40 b=50 c=45 en büyüğünü yazınız.

        /* int a = 400;
        int b = 50;
        int c = 450;

        int max = int.MinValue;

        if (a > max)
        {
            max = a;
        }
        if (b > a)
        {
            max = b;
        }
        if (c > max)
        {
            max = c;
        }
        System.Console.WriteLine($"En büyük sayi: {max}"); */
        #endregion

        #region ArrayExamp6
        //20 elemanınlı bir int dizisine 1-100 arasında rastgele değerler atıyalım ardından bu dizin içindeki en byük ve en küçük değeri ekrana yazdıralım.


        /* Random rndSayi = new Random();
        int[] numbers = new int[20]; // int[] numbers = [20]; = Yeni versiyonla gelen yapı.

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rndSayi.Next(1, 101);
            System.Console.WriteLine(numbers[i]);
        }
        //En büyük ve en küçük bulma
        int max = int.MinValue;
        int min = int.MaxValue;

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
            if (number < min)
            {
                min = number;
            }
        }

        //sonuç yazdırma.
        System.Console.Write($"En Küçük: {min} \nEn Büyük: {max}"); */
        #endregion

        #region ArraysExamp7

        /* Random rndSayi = new Random();
        int[] numbers = new int[10]; // int[] numbers = [20]; = Yeni versiyonla gelen yapı.

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rndSayi.Next(1, 1001);
            System.Console.WriteLine(numbers[i]);
        }
        Array.Sort(numbers);
        System.Console.WriteLine("Dizinin küçükten büyüğe sirali hali.");
        System.Console.WriteLine("------------------------");
        for (int i = 0; i < numbers.Length; i++)
        {
            System.Console.WriteLine(numbers[i]);
        }
        Array.Reverse(numbers);
        System.Console.WriteLine("Dizinin büyükten küçüğe sirali hali.");
        System.Console.WriteLine("------------------------");
        for (int i = 0; i < numbers.Length; i++)
        {
            System.Console.WriteLine(numbers[i]);
        } */

        #endregion

        #region ArraysExamp8

        /*  Random rndSayi = new Random();
         int[] numbers = new int[10]; // int[] numbers = [20]; = Yeni versiyonla gelen yapı.

         for (int i = 0; i < numbers.Length; i++)
         {

             numbers[i] = rndSayi.Next(1, 1001);

         }
         numbers[5] = 99;
         for (int i = 0; i < numbers.Length; i++)
         {

             System.Console.WriteLine($"Index: {i}- Number: {numbers[i]}");
         }


         System.Console.WriteLine(Array.IndexOf(numbers, 99));
  */
        #endregion

        #region Arrays_Stirng_Examp9

        /* string firstName = "Alex De Souza";
        System.Console.WriteLine(firstName[3]); */
        #endregion

        #region Split
        /* string text = "Macbook ile yazılım geliştirme ortamının hazırlanması:";
        string[] result = text.Split(" ");

        System.Console.WriteLine(result[0]); */
        #endregion

        #region SplitHomeworkSolution

        /* string text = "çok hava çok güzel çok";
        string[] result = text.Split("çok");
        int wordCount = result.Length - 1;
        System.Console.WriteLine(wordCount); */

        #endregion

        #region Arrays-SplitExamp
        //Dizileri kopyalamak

        /* string[] names = ["Ayşen", "Umay", "Ceyda", "Begüm"];
        string[] newNames = new string[names.Length];
        Array.Copy(names, newNames, 4); // Almak istediğin kadar eleman yaz.

        System.Console.WriteLine("Değişmeden önceki hali:");
        System.Console.WriteLine("-----------------------");

        foreach (var name in names)
        {
            System.Console.WriteLine(name);
        }
        newNames[0] = "Heda";

        System.Console.WriteLine("Değişmiş Hali:");
        System.Console.WriteLine("------------------");

        foreach (var name in newNames)
        {
            System.Console.WriteLine(name);
        } */
        #endregion

        #region Dizide Var/Yok kontrolü yapmak

        /* int[] numbers = [3, 6, 7, 12];
        bool exist = Array.Exists(numbers, no => no > 6);
        System.Console.WriteLine(exist ? "var" : "yok"); */

        #endregion

        #region Array.Find
        //Dizide belirtilen koşula uyan ilk elemanı getirmek.

        /* int[] numbers = [3, 6, 7, 12];
        int result = Array.Find(numbers, no => no == 6);
        System.Console.WriteLine(result);
 */
        #endregion

        #region Array.Find2

        //Dizide belirtilen koşula uygun tüm elemanları getir.
        /*  int[] numbers = [3, 6, 7, 12, 6];
         int[] result = Array.FindAll(numbers, no => no == 6);
         foreach (var no in result)
         {
             System.Console.WriteLine(no);
         } */

        #endregion

        #region Dizinin boyutunu (Eleman sayısını) değiştirmek

        /* int[] numbers = [3, 6, 8];
        System.Console.WriteLine(numbers.Length);
        Array.Resize(ref numbers, numbers.Length1);
        numbers[3] = 55;
        System.Console.WriteLine(numbers.Length);
 */
        #endregion

        #region Dizin belirli bir bölümünü temizlemek

        int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8];

        System.Console.WriteLine("Orjinal Hali");
        System.Console.WriteLine("------------");

        foreach (int number in numbers)
        {
            System.Console.WriteLine(number);
        }
        Array.Clear(numbers, 1, 6);

        System.Console.WriteLine("Tamizlenmiş Hali");
        System.Console.WriteLine("------------");

        foreach (int number in numbers)
        {
            System.Console.WriteLine(number);
        }

        #endregion
    }
}
