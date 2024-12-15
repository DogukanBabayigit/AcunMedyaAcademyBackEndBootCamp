using System.Globalization;
using System.Numerics;

namespace Project18_MethodSamples;

class Program
{
    //Kendisine gönderilen int tipindeli sayi dizininde yer alan negatif sayilari geri döndüren bir metot hazirlayalim.

    static List<int> GetNegativeNumbers(List<int> numbers)
    {
        List<int> negativeNumbers = new List<int>();
        foreach (var number in numbers)
        {
            if (number < 0)
            {
                negativeNumbers.Add(number);
            }

        }
        return negativeNumbers;
    }

    static int TotalOfSquares(int sayi1, int sayi2)
    {
        // int square1 = sayi1 * sayi1;
        // int square2 = sayi2 * sayi2;
        // int result = square1 + square2;
        // return result;
        return (sayi1 * sayi1) + (sayi2 * sayi2);
    }

    static void Main(string[] args)
    {
        System.Console.WriteLine(TotalOfSquares(4, 7));
        System.Console.WriteLine(TotalOfSquares(5, 7));
        System.Console.WriteLine(TotalOfSquares(2, 8));




        // List<int> numbers = [5, 7, 8, -5, -4, 3, -12, 4, 5, 7];
        // List<int> resultNumbers = GetNegativeNumbers(numbers);
        // foreach (var number in resultNumbers)
        // {
        //     System.Console.WriteLine(number);
        // }
    }
}
