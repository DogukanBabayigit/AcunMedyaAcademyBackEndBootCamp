using System;

namespace Project23_InheritanceSamples.SchoolSystem;

public class Person
{
    public Person(string name, string lastName, DateTime birthDate)
    {
        Name = name;
        LastName = lastName;
        BirthDate = birthDate;
    }

    public string Name { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }

    public byte Age // Salt okunur (Read Only)
    {
        get
        {
            return (byte)(DateTime.Now.Year - BirthDate.Year);
        }
    }

    public virtual void GetUsertInfo()
    {
        System.Console.WriteLine($"Ad: {Name}\nSoyad: {LastName}\nDoğum Tarihi: {BirthDate}");
    }

























}
