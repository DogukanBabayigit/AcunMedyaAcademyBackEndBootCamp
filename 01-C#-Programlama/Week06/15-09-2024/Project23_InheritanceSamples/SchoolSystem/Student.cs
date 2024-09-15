using System;

namespace Project23_InheritanceSamples.SchoolSystem;
/* 
    Öğrenci bir kişidir.
    Öğrenci Numarası
    Bilgileri ekrana yazdırılırken Öğrenci numarasıda yazdırılmalıdır.
 */
public class Student : Person
{

    public Student(string name, string lastName, DateTime birthDate, int studentNumber) : base(name, lastName, birthDate)
    {
        StudentNumber = studentNumber;
    }

    public int StudentNumber { get; set; }
    public override void GetUsertInfo()
    {
        base.GetUsertInfo();
        System.Console.WriteLine($"Student No.: {StudentNumber}");
    }

}
