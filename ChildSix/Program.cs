using System;
using System.Globalization;

class SmartSavingsTracker
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Username: ");
        string userName = Console.ReadLine();

        Console.Write("Enter your current balance: ");
        int currentBalance = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your monthly goal: ");
        int monthlyGoal = Convert.ToInt32(Console.ReadLine());

        int futureBalance = currentBalance + monthlyGoal;

        Console.WriteLine($"User: {userName} Current Balance: ${currentBalance}. If you hit your goal, your new balance will be ${futureBalance}!");


        Console.ReadKey();
    }
}