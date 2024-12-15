namespace _09_Banking_Application;

public class Account
{
    public string AccountNumber { get; set; }
    public decimal Balance { get; protected set; }

    public Account(string accountNumber, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"{amount:C} yatırıldı. Yeni bakiye: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Geçersiz tutar. Pozitif bir değer giriniz.");
        }
    }

    public virtual void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"{amount:C} çekildi. Yeni bakiye: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Yetersiz bakiye veya geçersiz tutar.");
        }
    }
}

public class SavingsAccount : Account
{
    public decimal InterestRate { get; set; }

    public SavingsAccount(string accountNumber, decimal initialBalance, decimal interestRate)
        : base(accountNumber, initialBalance)
    {
        InterestRate = interestRate;
    }

    public void AddInterest()
    {
        decimal interest = Balance * InterestRate / 100;
        Balance += interest;
        Console.WriteLine($"{interest:C} faiz eklendi. Yeni bakiye: {Balance:C}");
    }
}

public class CheckingAccount : Account
{
    public CheckingAccount(string accountNumber, decimal initialBalance)
        : base(accountNumber, initialBalance)
    {
    }

    public void WriteCheck(decimal amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Withdraw(amount);
            Console.WriteLine($"{amount:C} tutarında çek yazıldı.");
        }
        else
        {
            Console.WriteLine("Yetersiz bakiye veya geçersiz tutar.");
        }
    }

    public override void Withdraw(decimal amount)
    {
        if (amount <= Balance)
        {
            base.Withdraw(amount);
        }
        else
        {
            Console.WriteLine("Vadesiz hesap için yetersiz bakiye.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        SavingsAccount savingsAccount = new SavingsAccount("SA12345", 1000m, 2m);
        CheckingAccount checkingAccount = new CheckingAccount("CA54321", 500m);

        savingsAccount.Deposit(200);
        savingsAccount.AddInterest();
        savingsAccount.Withdraw(100);
        Console.WriteLine();

        checkingAccount.Deposit(300);
        checkingAccount.WriteCheck(200);
        checkingAccount.Withdraw(100);
    }
}
