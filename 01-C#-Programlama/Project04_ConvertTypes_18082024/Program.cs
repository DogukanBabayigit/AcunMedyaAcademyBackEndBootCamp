using System.ComponentModel;

namespace Project04_ConvertTypes_18082024;

class Program
{
    static void Main(string[] args)
    {
        #region Imlicit Convert(Örtülü Dönüştürme) 

        /*     // Küçük olan değeri büyük değere çevirme

            int myAge = 49;
            long newMyAge = myAge ; // int to long

            float rate = 0.87f;
            double newRate = rate;// float to double

            byte studentNote=75;
            int newStudentNote = studentNote; // byte to int */


        #endregion

        #region Explict Convert(Açık Dönüştürme)
        // Cast ve Unboxing Yönetmi:
        // double myValue = 123.58;
        // int newMyValue = (int)myValue;    
        // System.Console.WriteLine("myValue:  " + myValue);
        // System.Console.WriteLine("newMyValue:  " + newMyValue);

        // string numberString = "125";
        // int result = Convert.ToInt32(numberString) + 75;
        // System.Console.WriteLine(result);

        // long numberLong = 75;
        // int numberInt = Convert.ToInt32(numberLong);
        // System.Console.WriteLine(numberInt);

        // int numberInt = 256;
        // byte numberByte = Convert.ToByte(numberInt);
        // System.Console.WriteLine(numberByte);

        // string age = "43";
        // byte ageByte = byte.Parse(age);
        // System.Console.WriteLine(ageByte);

        // string number ="125&";
        // int numberInt = int.Parse(number);
        // System.Console.WriteLine(numberInt);

        // string number = "1234";
        // int  numberInt;
        // bool result = int.TryParse(number , out numberInt);
        // System.Console.WriteLine(result);

        // int a = 567;
        // string b = a.ToString();
        // System.Console.WriteLine(b);

        int a = 6;
        int b = 175;
        string resulString = a.ToString() + b.ToString();
        string resultString2 = (a+b).ToString();

        System.Console.WriteLine(resulString);
        System.Console.WriteLine(resultString2);
        #endregion











    }

}
