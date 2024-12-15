// using System.ComponentModel;

// namespace Project10_ErrorHandling;

// class Program
// {
//     static void Main(string[] args)
//     {
//         #region Try Catch Syntax
//         // try
//         // {

//         // }
//         // catch (System.Exception)
//         // {

//         //     throw;
//         // }
//         #endregion

//         #region Try Catch

//         // Console.Clear();

//         int number1 = default;
//         int number2 = default;
//         string result = default; //"default"

//         try
//         {
//             System.Console.WriteLine("Birinci Sayi Giriniz: ");
//             number1 = int.Parse(Console.ReadLine());

//             System.Console.WriteLine("İkinci Sayi Giriniz: ");
//             number2 = int.Parse(Console.ReadLine());

//             result = (number1 / number2).ToString();

//             System.Console.WriteLine("Sonuc :" + result);
//         }
//         catch (FormatException)
//         {
//             result = "GEÇERLİ DEĞER GİRİNİZ! ";
//             System.Console.WriteLine();
//             //throw;
//         }
//         catch (OverflowException)//Taşma Hatası
//         {
//             result = $"Lütfen {int.MinValue}-{int.MaxValue} arasinda bir deger giriniz.";
//             System.Console.WriteLine();

//         }
//         catch (DivideByZeroException)
//         {
//             result = $"Sayi 0 Girdiğiniz için default olarak 1'e bölme işlemi yapildi.\nSonuc: {number1.ToString()}";
//         }
//         catch (Exception ex)
//         {
//             result = ex.Message;
//         }
//         finally
//         {
//             System.Console.WriteLine(result);
//         }

//         System.Console.WriteLine("Program Sona Erdi...");

//         #endregion
//     }
// }
