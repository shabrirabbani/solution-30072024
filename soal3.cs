using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = 12;
        List<int> fibonacciSequence = Fibonacci(n);

        Console.WriteLine(string.Join(" ", fibonacciSequence));
    }

    static List<int> Fibonacci(int n)
    {
        List<int> fib = new List<int>();

        if (n <= 0)
        {
            return fib;
        }
        
        fib.Add(1);
        if (n == 1)
        {
            return fib;
        }

        fib.Add(1);
        while (true)
        {
            int nextValue = fib[fib.Count - 1] + fib[fib.Count - 2];
            if (nextValue > n)
            {
                break;
            }
            fib.Add(nextValue);
        }

        return fib;
    }
}
