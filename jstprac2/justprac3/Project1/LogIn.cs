using System;
namespace Project1;

public static class LogIn
{
    public static void Question()
    {
        Console.WriteLine();

        Console.WriteLine($"Welcome, {SignIn.UserName}! Please LogIn."); Console.WriteLine();

        string IdNumber;
        string Password;

        Console.Write("Enter Id Number: ");
        IdNumber = Console.ReadLine();

        Console.Write("Enter password: ");
        Password = Console.ReadLine();


        do
        {
            Console.WriteLine("Incorrect Id Number or Password.");Console.WriteLine();

            Console.Write("Enter Id Number: ");
          IdNumber = Console.ReadLine();

        Console.Write("Enter password: ");
          Password = Console.ReadLine();
   

        } while (IdNumber != SignIn.IdNumber && Password != SignIn.Password);
          Environment.Introduce(); Console.WriteLine();
    }
}   