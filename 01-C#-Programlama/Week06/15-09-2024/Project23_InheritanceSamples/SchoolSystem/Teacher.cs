using System;

namespace Project23_InheritanceSamples.SchoolSystem;

/* 
    Bir kişidir.
    Ek olarak branş ve maaş bilgisi olacak
    Maaş bilgisi negatif değer olarak girilemez.(Hata MEsajı versek yeter.)
    Bilgileri ekrana yazdırılırken branş ve maaş bilgiside yazdırılacak.
 */

public class Teacher : Person
{

    public Teacher(string name, string lastName, DateTime birthDate) : base(name, lastName, birthDate)
    {
    }

    public Teacher(string name, string lastName, DateTime birthDate, string brans, int payment) : base(name, lastName, birthDate)
    {
        Brans = brans;
        Payment = payment;
    }
    public string Brans { get; set; }
    decimal payment;
    public decimal Payment
    {
        get { return payment; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Geçerli Maaş Giriniz...");
            }
            payment = value;
        }
    }

    public override void GetUsertInfo()
    {
        base.GetUsertInfo();
        System.Console.WriteLine($"Branş: {Brans}\nPayment: {Payment:C2}");
    }
}
