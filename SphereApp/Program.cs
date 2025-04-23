using System;

class Sphere
{
    int radius;
    double volume;

    void getradius()
    {
        Console.WriteLine("Enter the radius: ");
        radius = int.Parse(Console.ReadLine());
    }

    double computeVolume()
    {
        volume = (4 * Math.PI * Math.Pow(radius, 3)) / 3;
        return volume;
    }

    void print()
    {
        Console.WriteLine("The volume of a sphere whose radius = " + radius + " is " + volume);
    }

    static void Main(string[] args)
    {
        Sphere sphere = new Sphere();
        sphere.getradius();
        sphere.computeVolume();
        sphere.print();

        Console.ReadLine(); // Optional: keeps console open
    }
}
