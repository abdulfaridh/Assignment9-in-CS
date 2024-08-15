// See https://aka.ms/new-console-template for more information
using System;

class Assignment9
{
    static void Main()
    {
        Console.WriteLine("Enter the number of days the book is returned late:");
        int lateDays = int.Parse(Console.ReadLine());

        double fine = CalculateFine(lateDays);

        if (lateDays > 30)
        {
            Console.WriteLine("Membership canceled.");
            Console.WriteLine("Fine: $" + fine);
        }
        else
        {
            Console.WriteLine("Fine: $" + fine);
        }
    }

    static double CalculateFine(int daysLate)
    {
        if (daysLate <= 5)
        {
            return 0;
        }
        else if (daysLate <= 10)
        {
            return 0.5 * (daysLate - 5);
        }
        else if (daysLate <= 30)
        {
            return (0.5 * 5) + (1 * (daysLate - 10));
        }
        else
        {
            return (0.5 * 5) + (1 * 20) + (1.5 * (daysLate - 30));
        }
    }
}

