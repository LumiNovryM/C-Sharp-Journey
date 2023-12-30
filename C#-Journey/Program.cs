internal class Program
{
    private static void Main(string[] args)
    {
        // 1.Variable
        int age = 18;
        double phi = 3.14;
        char a = 'A';
        string name = "Lumi Novry Meckel";
        bool isMarried = false;

        // Replace Variable Value
        age = 19;

        Console.WriteLine("Lumi: Hai My Name Is " + name);
        Console.WriteLine("Lumi: Im " + age + " Years Old");
        Console.WriteLine("Nice To Meet You");


        // 2.User Input
        Console.WriteLine("Lumi: What is Your Name?");

        string userName = Console.ReadLine();

        Console.WriteLine("{0} : My Name Is {0}", userName);

        Console.WriteLine("Lumi: Nice To Meet You, {0}", userName);
    }
}