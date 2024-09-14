namespace Project20_OOP_Intro;

class FirstClass
{
    //Buraya Sınıfın Özellik Ve Davranışlarını kodluyor olacağız.
    //Özellik:Property
    //Davranış: Method
    // Private veya Public Yazılmadıysa :(private)string message; değişkeni private değişkendir.
    /* string message;
    string age; */


    public string message;
    public string age;

    public void DisplayMessage()
    {
        System.Console.WriteLine(message);
    }
}


class Program
{
    //Obejct Orianted Project
    static void Main(string[] args)
    {
        FirstClass firstClass1 = new FirstClass(); // FirstClass1 adından bir değişken oluşturur ve tipinde bir nesne oluşturuyor. 
        //Ne zaman FristClass den bahsedilse adresten gidip FirstClass'ı çağırıyor.
        firstClass1.message = "Selam";
        /* System.Console.WriteLine(firstClass1.message); */
        firstClass1.DisplayMessage();
        //Bir class kullandığınızda o klasın canlandığı andır.
    }
}
