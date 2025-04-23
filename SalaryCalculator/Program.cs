using System;

class Salary
{
    // Member variables
    double basic_salary;
    double allowance;
    double tax_rate;
    double tax_amount;
    double net_salary;

    // Method to input data
    public void input()
    {
        Console.Write("Enter basic salary: ");
        basic_salary = double.Parse(Console.ReadLine());

        Console.Write("Enter allowance: ");
        allowance = double.Parse(Console.ReadLine());

        Console.Write("Enter tax rate (%): ");
        tax_rate = double.Parse(Console.ReadLine());
    }

    // Method to compute tax amount and net salary
    public void compute()
    {
        tax_amount = tax_rate / 100 * (basic_salary + allowance);
        net_salary = basic_salary - tax_amount;
    }

    // Method to output the results
    public void output()
    {
        Console.WriteLine("\n----- Salary Details -----");
        Console.WriteLine("Basic Salary: " + basic_salary);
        Console.WriteLine("Allowance: " + allowance);
        Console.WriteLine("Tax Rate: " + tax_rate + "%");
        Console.WriteLine("Tax Amount: " + tax_amount);
        Console.WriteLine("Net Salary: " + net_salary);
    }

    // Main method
    static void Main(string[] args)
    {
        Salary emp = new Salary();
        emp.input();
        emp.compute();
        emp.output();

        Console.ReadLine(); // Keeps the console open
    }
}
