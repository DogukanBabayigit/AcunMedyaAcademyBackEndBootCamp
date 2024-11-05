namespace _05_Calendar_Application;
public class Event
{
    public string Name { get; set; }
    public DateTime EventDate { get; set; }
    public string Location { get; set; }

    public Event(string name, DateTime eventdate, string location)
    {
        Name = name;
        EventDate = eventdate;
        Location = location;
    }

    public virtual void DisplayInfo()
    {
        System.Console.WriteLine($"Etkinlik Adi: {Name} - Tarih: {EventDate.ToString("dd/MM/yyyy")} - Yer: {Location}");
    }
}

public class Meeting : Event
{
    public string Agenda { get; set; }

    public Meeting(string name, DateTime eventdate, string location, string agenda) : base(name, eventdate, location)
    {
        Agenda = agenda;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        System.Console.WriteLine($"Toplanti Gundemi: {Agenda}");
    }
    public class Birthday : Event
    {
        public string BirthdayPerson { get; set; }

        public Birthday(string name, DateTime date, string location, string birthdayPerson)
            : base(name, date, location)
        {
            BirthdayPerson = birthdayPerson;
        }

        public void Celebrate()
        {
            Console.WriteLine($"Mutlu Yıllar, {BirthdayPerson}! {Name} doğum günü kutlaması başlıyor!");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Doğum Günü Sahibi: {BirthdayPerson}");
        }
    }
    public class Task : Event
    {
        public bool IsComplete { get; private set; } = false;

        public Task(string name, DateTime date, string location)
            : base(name, date, location)
        {
        }
        public void MarkAsComplete()
        {
            if (!IsComplete)
            {
                IsComplete = true;
                Console.WriteLine($"{Name} görevi tamamlandı olarak işaretlendi.");
            }
            else
            {
                Console.WriteLine($"{Name} görevi zaten tamamlandı.");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Meeting meeting = new Meeting("Proje Toplantısı", new DateTime(2024, 11, 15), "Toplantı Odası", "Yeni proje planlaması");
            Birthday birthday = new Birthday("Ayşe'nin Doğum Günü", new DateTime(2024, 12, 20), "Ayşe'nin Evi", "Ayşe");
            Task task = new Task("Rapor Tamamlama", new DateTime(2024, 11, 5), "Ofis");

            // Etkinlik bilgilerini gösterme
            meeting.DisplayInfo();
            Console.WriteLine();
            birthday.DisplayInfo();
            birthday.Celebrate();
            Console.WriteLine();
            task.DisplayInfo();
            task.MarkAsComplete();
            task.DisplayInfo();
        }
    }
}