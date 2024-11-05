namespace _10_Game_Characters;

public class Character
{
    public string Name { get; set; }
    public int Health { get; protected set; }

    public Character(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Karakter Adı: {Name}, Sağlık: {Health}");
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            Health = 0;
            Console.WriteLine($"{Name} öldü.");
        }
        else
        {
            Console.WriteLine($"{Name} {damage} hasar aldı. Kalan sağlık: {Health}");
        }
    }
}

public class Warrior : Character
{
    public Warrior(string name, int health)
        : base(name, health)
    {
    }

    public void SwordAttack(Character target)
    {
        int damage = 20;
        Console.WriteLine($"{Name} {target.Name}'e kılıç saldırısı yaptı ve {damage} hasar verdi.");
        target.TakeDamage(damage);
    }
}

public class Mage : Character
{
    public Mage(string name, int health)
        : base(name, health)
    {
    }

    public void CastSpell(Character target)
    {
        int damage = 25;
        Console.WriteLine($"{Name} {target.Name}'e büyü yaptı ve {damage} hasar verdi.");
        target.TakeDamage(damage);
    }
}

// Okçu sınıfı (Archer)
public class Archer : Character
{
    public Archer(string name, int health)
        : base(name, health)
    {
    }

    public void ArrowShot(Character target)
    {
        int damage = 15;
        Console.WriteLine($"{Name} {target.Name}'e ok attı ve {damage} hasar verdi.");
        target.TakeDamage(damage);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Warrior warrior = new Warrior("Savaşçı", 100);
        Mage mage = new Mage("Büyücü", 80);
        Archer archer = new Archer("Okçu", 90);

        warrior.DisplayInfo();
        mage.DisplayInfo();
        archer.DisplayInfo();
        Console.WriteLine();

        warrior.SwordAttack(mage);

        mage.CastSpell(archer);

        archer.ArrowShot(warrior);
    }
}
