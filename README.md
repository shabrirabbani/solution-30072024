# solution-30072024

# Muhammad Shabri Rabbani

## Soal 1

```sql
SELECT barang.KODEBRG, barang.NAMABRG, COALESCE(SUM(jual.JUMLAH), 0) AS JML_JUAL
FROM BARANG barang
LEFT JOIN JUAL jual ON barang.KODEBRG = jual.KODEBRG
GROUP BY barang.KODEBRG, barang.NAMABRG
ORDER BY JML_JUAL DESC;
```

## Soal 2

```sql
WITH LastStock AS (
    SELECT KodeBarang, StokAkhir, ROW_NUMBER() OVER (PARTITION BY KodeBarang ORDER BY Tanggal DESC, KodeStok DESC) AS rn
    FROM HistoriStokBarang
)
SELECT KodeBarang, StokAkhir
FROM LastStock
WHERE rn = 1
ORDER BY KodeBarang;
```

## Soal 3

```c#
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

```

## Soal 4
```c#
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

```

## soal 5
```c#
using System;

class Program
{
    static void Main()
    {
        int input1 = 5; 
        int input2 = 4; 
        string result = PadNumber(input1, input2);
        
        Console.WriteLine(result);
    }

    static string PadNumber(int input1, int input2)
    {
        string numString = input1.ToString();
        string paddedNumber = numString.PadLeft(input2, '0');
        return paddedNumber;
    }
}

```
