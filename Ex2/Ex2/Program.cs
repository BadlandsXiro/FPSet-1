using System;

class Program
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            if (b != 0)
                Console.WriteLine("x = " + (-c / b));
            else
                Console.WriteLine(c == 0 ? "Infinit de solutii" : "Fara solutii");
        }
        else
        {
            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"x1 = {x1}, x2 = {x2}");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("x = " + x);
            }
            else
            {
                Console.WriteLine("Nu are solutii reale");
            }
        }
    }
}
