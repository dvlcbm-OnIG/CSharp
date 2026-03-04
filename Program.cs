using System;

class RpgInventoryCheck
{
    public static void Main(string[] args)
    {
        Console.Write("Enter character name: ");
        string characterName = Console.ReadLine();

        Console.Write("Enter item name: ");
        string itemName = Console.ReadLine();

        Console.Write("Enter curent item amount: ");
        int currentAmount = Convert.ToInt32(Console.ReadLine());

        int newAmount = currentAmount + 5;

        Console.WriteLine($"{characterName}, you found a chest! You now have {newAmount} {itemName}. Keep going!");

        Console.ReadKey();
    }
}