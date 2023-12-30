// Create Blueprint/Class
internal class Manusia
{
    // Deklarasi Property Pada Sebuah Class
    int umur;
    string nama;

    public void SayHi()
    {
        System.Console.WriteLine("Halo, Apa Kabar!");
    }

}

internal class User
{
    static void Main(string[] args)
    {
        // Instance New Object
        Manusia Lumi = new Manusia();
        Lumi.SayHi();
    }
}