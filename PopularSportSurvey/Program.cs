using System;

class Program
{
    static void Main(string[] args)
    {
        int F = 0, B = 0, S = 0, A = 0;
        char vote;

        do
        {
            Console.WriteLine("Select the Sport you Support:");
            Console.WriteLine("A - Athletics, S - Swimming, F - Soccer, B - Badminton");
            Console.WriteLine("Enter Q to finish the tally");
            vote = char.ToUpper(char.Parse(Console.ReadLine()));

            if (vote == 'F')
            {
                F += 1;
            }
            else if (vote == 'B')
            {
                B += 1;
            }
            else if (vote == 'S')
            {
                S += 1;
            }
            else if (vote == 'A')
            {
                A += 1;
            }

            Console.Clear();

        } while (vote != 'Q');

        Console.WriteLine("=== Tally Results ===");
        Console.WriteLine("Soccer: " + F);
        Console.WriteLine("Athletics: " + A);
        Console.WriteLine("Swimming: " + S);
        Console.WriteLine("Badminton: " + B);

        // Determine the favorite sport
        if (F > A && F > B && F > S)
        {
            Console.WriteLine("The favorite game is Soccer");
        }
        else if (A > F && A > B && A > S)
        {
            Console.WriteLine("The favorite game is Athletics");
        }
        else if (B > F && B > S && B > A)
        {
            Console.WriteLine("The favorite game is Badminton");
        }
        else if (S > A && S > B && S > F)
        {
            Console.WriteLine("The favorite game is Swimming");
        }
        else
        {
            Console.WriteLine("It's hard to determine the most popular sport (tie or unclear votes).");
        }

        Console.ReadLine();
    }
}
