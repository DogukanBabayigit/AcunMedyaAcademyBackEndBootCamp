namespace _06_Calculator;

public class Calculator
{
    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Subtract(double a, double b)
    {
        return a - b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Bölme işlemi için ikinci sayı sıfır olamaz.");
        }
        return a / b;
    }
}

public class ScientificCalculator : Calculator
{
    public double Sin(double angleInDegrees)
    {
        double angleInRadians = angleInDegrees * (Math.PI / 180);
        return Math.Sin(angleInRadians);
    }

    public double Cos(double angleInDegrees)
    {
        double angleInRadians = angleInDegrees * (Math.PI / 180);
        return Math.Cos(angleInRadians);
    }
}

class Program
{
    static void Main(string[] args)
    {
        ScientificCalculator sciCalculator = new ScientificCalculator();

        Console.WriteLine("Toplama: 5 + 3 = " + sciCalculator.Add(5, 3));
        Console.WriteLine("Çıkarma: 10 - 4 = " + sciCalculator.Subtract(10, 4));
        Console.WriteLine("Çarpma: 6 * 7 = " + sciCalculator.Multiply(6, 7));
        Console.WriteLine("Bölme: 8 / 2 = " + sciCalculator.Divide(8, 2));

        Console.WriteLine("Sin(30) = " + sciCalculator.Sin(30));
        Console.WriteLine("Cos(60) = " + sciCalculator.Cos(60));
    }
}