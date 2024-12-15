namespace Project16_Methods;

class Program
{
    /* 
        <Erişim Belirleyici> <Geri Dönüş Tipi> MethodName(parameters_type parameters_name ...)
        {
            Method body
            Process will be act.
            return; (return value) (for only return values)
        }
     */

    /* 
        Void: Anahtar kelimesi, bir metodun hiçbir değer döndürmeyeceğini belirtmek için kullanılır.
        DRY-Don't repeat yourself.
     */

    static void Greet()
    {
        System.Console.WriteLine("Merhaba Alex");
    }

    static string Greet2(string name, bool gender)
    {
        if (gender)
        {
            return $"Merhaba {name} Hanim: ";
        }
        return $"Merhaba {name} Bey: ";


    }

    static int Sum1()
    {
        int a = 40;
        int b = 50;
        int c = a + b;
        return c;
    }

    static double SumSqrt(double no1, double no2)
    {
        double total = no1 + no2;
        double result = Math.Sqrt(total);
        return result;
    }

    static void sampleNumberValue(ref int originalNumber)
    {
        originalNumber += 3;
        System.Console.WriteLine($"Methodun içindeki yazdırma satırı: {originalNumber}");

    }

    static void Bolme(int bolunen, int bolen, out int bolum, out int kalan)
    {
        bolum = bolunen / bolen;
        kalan = bolunen % bolen;

    }

    static void Main(string[] args)
    {
        int bolum;
        int kalan;
        Bolme(8, 3, out bolum, out kalan);
        System.Console.WriteLine($"8/3 = {bolum}\n8/3 isleminden kalan= {kalan}");

        





        //Greet(); // (), Parametreyi çalıştırma.
        // //Sum1();
        // int x = Sum1(); // Bu aşamada sum1 değerini artık x değerinde tutabiliyoruz.
        // int y = Sum2(50/* number1 */, 70/* number2 */); //Bu durumda sum2 de bulunan no1 ve no2 değişknelerine değer ataması yaptık.
        // int z = Sum2(90, 250);
        // System.Console.WriteLine(x + y + z);

        // double result1 = SumSqrt(4, 12);//4
        // double result2 = SumSqrt(5, 11);//4
        // double result3 = SumSqrt(2, 23);//5
        // double result4 = SumSqrt(7, 42);//7

        // System.Console.WriteLine(Greet2("Tuna", true));
        // System.Console.WriteLine(Greet2("Doğukan", false));

        // int originalNumber = 15;
        // System.Console.WriteLine($"Methot çağırılmadan önceki orijinalNumber değeri: {originalNumber}");

        // sampleNumberValue(ref originalNumber);

        // System.Console.WriteLine($"Methot çalıştıktan sonraki orijinalNumber değeri: {originalNumber}");
    }

    static int Sum2(int number1, int number2)
    {
        int result = number1 + number2;
        return result;
    }


}
