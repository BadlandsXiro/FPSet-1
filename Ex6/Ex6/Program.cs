using System;

class Program
{
    static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("c = ");
        int c = int.Parse(Console.ReadLine());

        if (a + b > c && a + c > b && b + c > a)
            Console.WriteLine("Formeaza triunghi");
        else
            Console.WriteLine("Nu formeaza triunghi");
    }
}
