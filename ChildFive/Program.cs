using System;
using System.Globalization;

class TechSupportTicket
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your device name: ");
        string device = Console.ReadLine();

        Console.Write("Enter the brand of your device: ");
        string brand = Console.ReadLine();

        Console.Write("Enter the model year of your device: ");
        int year = Convert.ToInt32(Console.ReadLine());

        string ticketID = brand + year;

        Console.WriteLine($"Hello! Your {brand} {device} has been logged. Your support ID is {ticketID} -HELP.");


        Console.ReadKey();
    }
}