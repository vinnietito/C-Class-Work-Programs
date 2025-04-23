using System;

class Program
{
    static void Main(string[] args)
    {
        int evenSum = 0;
        long oddProduct = 1;

        for (int i = 20; i <= 40; i++)
        {
            if (i % 2 == 0)
            {
                evenSum += i;
            }
            else
            {
                oddProduct *= i;
            }
        }

        Console.WriteLine("Sum of even numbers between 20 and 40: " + evenSum);
        Console.WriteLine("Product of odd numbers between 20 and 40: " + oddProduct);

        Console.ReadLine();
    }
}
