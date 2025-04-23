using System;

class PopularSportSurvey
{
    static void Main(string[] args)
    {
        // Initialize counters for each sport
        int athletics = 0, swimming = 0, soccer = 0, badminton = 0;
        char choice;

        Console.WriteLine("=== Sport Popularity Survey ===");
        Console.WriteLine("Enter a letter to vote:");
        Console.WriteLine("A - Athletics, S - Swimming, F - Soccer, B - Badminton");
        Console.WriteLine("Type Q to finish voting.\n");

        do
        {
            Console.Write("Enter your choice: ");
            choice = char.ToUpper(Console.ReadKey().KeyChar); // convert input to uppercase
            Console.WriteLine();

            switch (choice)
            {
                case 'A':
                    athletics++;
                    break;
                case 'S':
                    swimming++;
                    break;
                case 'F':
                    soccer++;
                    break;
                case 'B':
                    badminton++;
                    break;
                case 'Q':
                    Console.WriteLine("Tallying complete...\n");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter A, S, F, B or Q.");
                    break;
            }

        } while (choice != 'Q');

        // Display results
        Console.WriteLine("=== Survey Results ===");
        Console.WriteLine($"Athletics: {athletics}");
        Console.WriteLine($"Swimming: {swimming}");
        Console.WriteLine($"Soccer: {soccer}");
        Console.WriteLine($"Badminton: {badminton}");

        // Determine the most popular sport
        int maxVotes = Math.Max(Math.Max(athletics, swimming), Math.Max(soccer, badminton));
        string popularSport = "";

        if (athletics == maxVotes) popularSport += "Athletics ";
        if (swimming == maxVotes) popularSport += "Swimming ";
        if (soccer == maxVotes) popularSport += "Soccer ";
        if (badminton == maxVotes) popularSport += "Badminton ";

        Console.WriteLine($"\nMost Popular Sport(s): {popularSport}");
        Console.ReadLine(); // Keeps the console open
    }
}
