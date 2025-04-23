using System;

class Program
{
    static void Main(string[] args)
    {
        int F = 0, B = 0, S = 0, A = 0;
        char vote = ' '; // ✅ Initialize to avoid CS0165

        do
        {
            Console.WriteLine("Select the Sport you Support:");
            Console.WriteLine("A - Athletics, S - Swimming, F - Soccer, B - Badminton");
            Console.WriteLine("Enter Q to finish the tally");

            string? input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input) && input.Length == 1)
            {
                vote = char.ToUpper(input[0]);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a single letter.");
                continue;
            }

            switch (vote)
            {
                case 'F':
                    F++;
                    break;
                case 'B':
                    B++;
                    break;
                case 'S':
                    S++;
                    break;
                case 'A':
                    A++;
                    break;
                case 'Q':
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter A, S, F, B or Q.");
                    break;
            }

            Console.Clear();

        } while (vote != 'Q');

        Console.WriteLine("=== Survey Results ===");
        Console.WriteLine($"Soccer: {F}");
        Console.WriteLine($"Badminton: {B}");
        Console.WriteLine($"Swimming: {S}");
        Console.WriteLine($"Athletics: {A}");

        if (F > A && F > B && F > S)
            Console.WriteLine("The most popular sport is Soccer.");
        else if (A > F && A > B && A > S)
            Console.WriteLine("The most popular sport is Athletics.");
        else if (B > F && B > A && B > S)
            Console.WriteLine("The most popular sport is Badminton.");
        else if (S > A && S > B && S > F)
            Console.WriteLine("The most popular sport is Swimming.");
        else
            Console.WriteLine("It's hard to determine the most popular sport due to a tie or equal votes.");

        Console.ReadLine();
    }
}
