using System;
using System.Globalization;

class SuperHeroIdentity
    public static void Main(string[] args)
    {
        Console.Write("Enter your real name: ");
        string realName = Console.ReadLine();

        Console.Write("Enter your hero name: ");
        string heroName = Console.ReadLine();

        Console.Write("Enter your power level (1-100): ");
        int powerLevel = Convert.ToInt32(Console.ReadLine());

        int energyUnits = powerLevel * 10;

        Console.WriteLine($"Identity Confirmed: {realName} is secretly {heroName}! Energy Output: {energyUnits} Tera-watts.");


        Console.ReadKey();
    }
}