using System;

class Program
{
    static void Main()
    {
        Console.Write("первое число = ");
        int start = int.Parse(Console.ReadLine()); 
        Console.Write("конечное число = ");
        int end = int.Parse(Console.ReadLine()); 

        for (int i = start; i <= end; i++)
        {
            bool isPrime = true;
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine(i);
            }
        }
    }
}


