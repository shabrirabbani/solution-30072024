using System;

class Program
{
    static void Main()
    {
        int n = 3;
        PrintStars(n);
    }

    static void PrintStars(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            string stars = new string('*', 2 * i - 1);
            Console.WriteLine(stars);
        }
    }
}
