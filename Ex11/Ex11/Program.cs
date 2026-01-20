using System;

class Program
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        while (n > 0)
        {
            Console.Write(n % 10);
            n /= 10;
        }
    }
}
