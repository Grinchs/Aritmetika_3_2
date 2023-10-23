
class Program
{
    static void Main()
    {
        Console.Write("Ievadiet vārdu: ");
        string vards = Console.ReadLine();

        Console.Write("Ievadiet uzvārdu: ");
        string uzvards = Console.ReadLine();

        string sveiciens = "Sveiks " + vards + " " + uzvards + "!";
        Console.WriteLine(sveiciens);      
    }
}
