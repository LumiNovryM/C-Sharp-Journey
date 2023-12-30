// Create Blueprint/Class
internal class Manusia
{
    // Encapsulation
    // Private
    // Protected
    // Public
    // Deklarasi Property Pada Sebuah Class
    public int umur;
    public string nama;

    public string createdAt = "12/31/2023";

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
        Lumi.nama = "Lumi Novry Meckel";
        Lumi.umur = 18;

        Console.WriteLine(Lumi.nama);
    }
}

class Testing
{
    static void Main(string[] args)
    {
        // Testing
        Manusia Testing = new Manusia();
        Console.WriteLine(Testing.createdAt);
    }
}