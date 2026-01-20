using System;

class Program
{
    static void Main()
    {
        Console.Write("Numar = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        for (int i = 1; i < k; i++)
            n /= 10;

        Console.WriteLine("Cifra este " + n % 10);
    }
}
