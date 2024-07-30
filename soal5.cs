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
