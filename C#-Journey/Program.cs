// Create Blueprint/Class
internal class Manusia
{
    // Deklarasi Property Pada Sebuah Class
    public int umur;
    public string nama;

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