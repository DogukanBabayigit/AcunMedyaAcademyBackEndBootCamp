namespace Project15_CreateAndAssignedTeams;

class Program
{
    static void Main(string[] args)
    {
        string[] students = [
            "Hakan Çakdı",
            "Tunacan Eşki",
            "Rojin Çetiz",
            "Elif Öztürk",
            "Ömer Taştekin",
            "Enes Kılıçaslan",
            "Atlas Uyar",
            "Erdem Yüce Gül",
            "Enes Can Aydemir",
            "Irmak Özen",
            "Burhan Torun",
            "Miraç Katmer",
            "Bedirhan Çaylı",
            "Melina Balcı",
            "Merve Kahraman",
            "Kerem Can Kırpar",
            "Gizem Yüksel",
            "Celal Uğur Koçan",
            "Tahir Burak Avar",
            "Samet Önür",
            "Elifnur Binici",
            "Doğukan Babayiğit",
            "Emre Kılıç"
        ];

        string[] teamsNames = [
            "Debuggers",
            "Codewars",
            "Algoritmics",
            "BinaryCoders",
            "NullPointers",
            "Dev Dynamics"
        ];

        double memberCount = 4;
        int teamsCount = (int)Math.Ceiling(students.Length / memberCount);
        string[] teams = new string[teamsCount];

        //students dizimizi karıştıyoruz.

        Random rnd = new Random();
        int randomIndex;
        for (int i = 0; i < students.Length; i++)
        {
            randomIndex = rnd.Next(students.Length);
            string temp = students[i];
            students[i] = students[randomIndex];
            students[randomIndex] = temp;
        }
        int teamsCounter = 0;
        string currentTeamName;
        for (int i = 0; i < students.Length; i += 4)
        {
            currentTeamName = teamsNames[teamsCounter];
            System.Console.WriteLine($"Takım Adi: {currentTeamName} ");
            for (int j = 0; j < memberCount; j++)
            {
                System.Console.WriteLine($"\t\t-{students[i + j]}");
            }

            System.Console.WriteLine();
            teamsCounter++;

        }












        /* foreach (string s in students)
        {
            System.Console.WriteLine(s);
        } */


    }
}
