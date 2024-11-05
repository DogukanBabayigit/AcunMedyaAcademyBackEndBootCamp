namespace _03_Employee_Management_System;

public class Employee

{
    public string Name { get; set; }
    public int Id { get; set; }
    public decimal Salary { get; set; }



    public Employee(string name, int id, decimal salary)
    {
        Name = name;
        Id = id;
        Salary = salary;

    }

    public virtual void DisplayInfo()
    {
        System.Console.WriteLine($"Isim: {Name}, Kimlik No: {Id}, Maas: {Salary:C}");
    }
}

public class Manager : Employee
{
    public int NumberOfTeams { get; set; }
    public Manager(string name, int id, decimal salary, int numberOfTeams) : base(name, id, salary)
    {
        NumberOfTeams = numberOfTeams;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        System.Console.WriteLine($"Takim Sayisi : {NumberOfTeams}");
    }
}

public class Developer : Employee
{
    public string ProgrammingLanguage { get; set; }

    public Developer(string name, int id, decimal salary, string programmingLanguage) : base(name, id, salary)
    {
        ProgrammingLanguage = programmingLanguage;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        System.Console.WriteLine($"Programlama Dili: {ProgrammingLanguage}");
    }

    public class Trainee : Employee
    {
        public Trainee(string name, int id, decimal salary)
            : base(name, id, salary) { }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Pozisyon: Stajyer");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new("Ali Yilmaz", 1, 12000, 3);
            Developer developer = new("Ayse Demir", 2, 9000, "C#");
            Trainee trainee = new("Mehmet Kaya", 3, 3000);

            manager.DisplayInfo();
            System.Console.WriteLine();
            developer.DisplayInfo();
            System.Console.WriteLine();
            trainee.DisplayInfo();
        }
    }
}

