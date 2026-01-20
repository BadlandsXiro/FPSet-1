using System;

class Program
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        bool prim = n > 1;
        for (int i = 2; i * i <= n; i++)
            if (n % i == 0)
                prim = false;

        Console.WriteLine(prim ? "Numar prim" : "Nu este prim");
    }
}
