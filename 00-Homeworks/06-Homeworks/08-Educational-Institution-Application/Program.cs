namespace _08_Educational_Institution_Application;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"İsim: {Name}, Yaş: {Age}");
    }

    public virtual void AttendClass()
    {
        Console.WriteLine($"{Name} derse katılıyor.");
    }
}

public class Teacher : Person
{
    public string SubjectTaught { get; set; }

    public Teacher(string name, int age, string subjectTaught)
        : base(name, age)
    {
        SubjectTaught = subjectTaught;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Öğrettiği Konu: {SubjectTaught}");
    }

    public override void AttendClass()
    {
        Console.WriteLine($"{Name} öğretmen derse {SubjectTaught} dersiyle katılıyor.");
    }
}

public class Student : Person
{
    public int GradeLevel { get; set; }

    public Student(string name, int age, int gradeLevel)
        : base(name, age)
    {
        GradeLevel = gradeLevel;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Sınıf Seviyesi: {GradeLevel}");
    }

    public override void AttendClass()
    {
        Console.WriteLine($"{Name}, {GradeLevel}. sınıf öğrencisi olarak derse katılıyor.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Teacher teacher = new Teacher("Ali Yılmaz", 35, "Matematik");
        Student student = new Student("Ayşe Demir", 16, 10);

        teacher.DisplayInfo();
        teacher.AttendClass();
        Console.WriteLine();

        student.DisplayInfo();
        student.AttendClass();
    }
}
