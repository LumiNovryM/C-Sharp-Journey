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

internal class User : Manusia
{
    static void Instance(string[] args)
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
    static void Test(string[] args)
    {
        // Testing
        Manusia Testing = new Manusia();
        Console.WriteLine(Testing.createdAt);
    }
}


class Mobil
{
    public string Merek { get; set; }
    public int TahunProduksi { get; set; }

    // Class Constructor With Parameter
    public Mobil(string merek, int tahunProduksi)
    {
        Merek = merek;
        TahunProduksi = tahunProduksi;
    }

    public void TampilkanInfo()
    {
        Console.WriteLine($"Mobil {Merek} diproduksi pada tahun {TahunProduksi}");
    }
}


class Supra
{
    static void Main()

    {
        // Membuat object instance dari Class Mobil menggunakan constructor
        Mobil Supra = new Mobil("Supra GTR", 2005);

        // Memanggil method untuk menampilkan informasi mobil
        Supra.TampilkanInfo();
    }
}