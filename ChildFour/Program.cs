using System;
using System.Globalization;

class GamerProfile
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your fist name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter your last name: ");
        string lastName = Console.ReadLine();

        Console.Write("Enter your current level: ");
        int level = Convert.ToInt32(Console.ReadLine());
 
        int nextLevel = level + 1;

        Console.WriteLine($"Profile Created: {lastName}, {firstName}. Current Rank: {level}. Get ready for level {nextLevel}!");



        Console.ReadKey();
    }
}