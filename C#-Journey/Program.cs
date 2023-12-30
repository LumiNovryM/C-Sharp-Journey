internal class Program
{
    private static void Main(string[] args)
    {
        // 1.Variable
        // int age = 18;
        // double phi = 3.14;
        // char a = 'A';
        // string name = "Lumi Novry Meckel";
        // bool isMarried = false;

        // Replace Variable Value
        // age = 19;

        // Console.WriteLine("Lumi: Hai My Name Is " + name);
        // Console.WriteLine("Lumi: Im " + age + " Years Old");
        // Console.WriteLine("Nice To Meet You");


        // 2.User Input
        // Console.WriteLine("Lumi: What is Your Name?");
        // string userName = Console.ReadLine();
        // Console.WriteLine("{0} : My Name Is {0}", userName);
        // Console.WriteLine("Lumi: Nice To Meet You, {0}", userName);

        // 3.Aritmatika
        // Console.WriteLine("Masukkan Angka Ke 1 : ");
        // int firstNum = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Masukkang Angka Ke 2 : ");
        // int secondNum = Convert.ToInt32(Console.ReadLine());

        // Console.WriteLine("Hasil Penjumlahan : {0}", firstNum + secondNum);
        // Console.WriteLine("Hasil Pengurangan : {0}", firstNum - secondNum);
        // Console.WriteLine("Hasil Perkalian : {0}", firstNum * secondNum);
        // Console.WriteLine("Hasil Pembagian : {0}", Convert.ToDouble(firstNum) / Convert.ToDouble(secondNum));
        // Console.WriteLine("Hasil Modulus : {0}", firstNum % secondNum);


        // 4.If Else Statement
        // string name = "Lumi Novry Meckel";
        // if(name == "Lumi Novry Meckel")
        // {
        //     Console.WriteLine("Hai {0}", name);
        // }
        // else
        // {
        //    Console.WriteLine("Hai");
        // }

        // 5.Increment & Decrement
        // int increment = 15;
        // int decrement = 15;
        // increment++; // Increment, yaitu menambah satu angka
        // decrement--; // Decrement, yaitu mengurang satu angka

        // dynamic test = ++increment;
        // Console.WriteLine(test);

        // Console.WriteLine(increment);
        // Console.WriteLine(decrement);

        // 6.Switch Case Statement
        // int age = 18;
        // switch (age)
        // {
        //     case 18:
        //         Console.WriteLine("Anda Boleh Masuk Ke Ruangan Ini");
        //         break;
        //     case 17:
        //         Console.WriteLine("Anda Tidak Boleh Masuk Ke Ruangan Ini");
        //         break; 
        //     default:
        //         Console.WriteLine("Tidak Boleh Masuk");
        //         break;
        // }

        // 7.While Loop
        // int x = 10;

        // while (x <= 15)
        // {
        //     Console.WriteLine(x);
        //     x++;
        // }

        // 8.Do While
        // int x = 1;
        // do
        // {
        //     Console.WriteLine(x);
        //     x++;
        // }
        // while (x <= 5);

        // 9.For Loop
        // for (int i = 0; i < 5; i++)
        // {
        //     Console.WriteLine(i);
        // }

        // 10.Logical Operator
        // && AND
        // || OR
        // ! NOT

        // Console.WriteLine("Input Your Username & Password To Login!");

        // string password = Console.ReadLine();
        // string username = Console.ReadLine();

        // if(password == "123" && username == "Lumi")
        // {
        //     Console.WriteLine("Access Granted");
        // }
        // else
        // {
        //     Console.WriteLine("Access Denied");
        // }


        // Memanggil Static Void Method
        // SayHi("Lumi");
        // Hitung(2, 3);

        // Memanggil Method Tanpa Default Value Pada Argument
        // int persegi = Luas();
        // Memanggil Method Dengan Default Value Pada Argument
        // int persegiPanjang = Luas(p:2, l:2);

        // int refArgs = 12;
        // Hitung(ref refArgs);

        // string myName;
        // PrintName(out myName);
        // Console.WriteLine(myName);


        // Memanggil Method Overloading
        // Print(18);
        // Print(3.14);
    }

    // 11.Static Void Method
    // static void SayHi(string name)
    // {
    //     Console.WriteLine("Hai {0}", name);
    // }

    // static void Hitung(int a, int b)
    // {
    //     Console.WriteLine(a + b);
    // }

    // 12.Method Arguments
    // Memberi Method Default
    // static int Luas(int p = 2, int l = 2)
    // {
    //     return p * l;
    // }

    // static void Hitung(ref int a)
    // {
    //     Console.WriteLine(a);
    // }

    // static void PrintName(out string name)
    // {
    //     name = "Lumi Novry Meckel";
    // }

    // 13.Method Overloading
    // static void Print(int age)
    // {
    //     Console.WriteLine("Print Int: {0}", age);
    // }

    // static void Print(double phi)
    // {
    //     Console.WriteLine("Print Double: {0}", phi);
    // }
}