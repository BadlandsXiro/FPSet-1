using System;

class Program
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        int copie = n, inv = 0;
        while (n > 0)
        {
            inv = inv * 10 + n % 10;
            n /= 10;
        }

        Console.WriteLine(copie == inv ? "Palindrom" : "Nu este palindrom");
    }
}
