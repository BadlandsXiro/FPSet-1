using System;

class Program
{
    static void Main()
    {
        Console.Write("Anul = ");
        int y = int.Parse(Console.ReadLine());

        bool bisect = (y % 400 == 0) || (y % 4 == 0 && y % 100 != 0);

        Console.WriteLine(bisect ? "An bisect" : "An obisnuit");
    }
}
