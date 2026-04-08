class Calculator
{
    static void Main(string[] args)
    {
        int a, b;

        Console.WriteLine("Angka pertama: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Angka kedua: ");
        b = Convert.ToInt32(Console.ReadLine());
        

        Console.WriteLine("Hasil Penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b));
        Console.WriteLine("Hasil Penambahan: {0} - {1} = {2}", a, b, Pengurangan(a, b));

        Console.WriteLine("\ntekan sembarang key untuk keluar");
        Console.ReadKey();
    }

    static int Penambahan(int a, int b)
    {
        return a + b;
    }

    static int Pengurangan(int a, int b)
    {
        return a + b;
    }
}