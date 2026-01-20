using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int x = a, y = b;
        while (y != 0)
        {
            int r = x % y;
            x = y;
            y = r;
        }

        int cmmdc = x;
        int cmmmc = a * b / cmmdc;

        Console.WriteLine("CMMDC = " + cmmdc);
        Console.WriteLine("CMMMC = " + cmmmc);
    }
}
