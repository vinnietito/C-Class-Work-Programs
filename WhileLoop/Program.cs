using System;

class Program
{
    static void Main(string[] args)
    {
        int c, i = 1;

        do
        {
            c = 1;
            do
            {
                Console.Write(c);
                c++; // Corrected 'C++' to 'c++'
            } while (c <= i); // Updated logic to print increasing values

            Console.WriteLine();
            i++;
        } while (i <= 5);

        Console.ReadLine();
    }
}
