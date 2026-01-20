using System;

class Program
{
    static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());

        int temp = a;
        a = b;
        b = temp;

        Console.WriteLine($"a = {a}, b = {b}");
    }
}
