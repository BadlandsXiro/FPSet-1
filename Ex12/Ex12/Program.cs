using System;

class Program
{
    static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        int count = b / n - (a - 1) / n;
        Console.WriteLine(count);
    }
}
