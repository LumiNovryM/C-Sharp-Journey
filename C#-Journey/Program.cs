internal class Program
{
    private static void Main(string[] args)
    {
        // Cara Deklarasi Variable Pada C#
        int age = 18;
        double phi = 3.14;
        char a = 'A';
        string name = "Lumi Novry Meckel";
        bool isMarried = false;

        Console.WriteLine("Hai My Name Is " + name);
        Console.WriteLine("Im " + age + " Years Old");
        if(isMarried == false)
        {
            Console.WriteLine("Lumi Is Not Married");
        }
        else
        {
            Console.WriteLine("Lumi Is Married");
        }
        Console.WriteLine("Nice To Meet You");
    }
}