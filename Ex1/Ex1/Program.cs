using System;

class Program
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());

        if (a != 0)
        {
            double x = -b / a;
            Console.WriteLine("Solutia este x = " + x);
        }
        else
        {
            if (b == 0)
                Console.WriteLine("Infinit de solutii");
            else
                Console.WriteLine("Nu exista solutii");
        }
    }
}
