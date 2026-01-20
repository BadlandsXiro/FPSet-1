using System;

class Program
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        if (n % k == 0)
            Console.WriteLine("n se divide cu k");
        else
            Console.WriteLine("n NU se divide cu k");
    }
}
