using System;
namespace Project1;

public static class SignIn
{
	//modern way of encapsulation
	public static string FullName { get; private set; }
	public static string IdNumber { get; private set; }
	public static string UserName { get; private set; }
	public static string Password { get; private set; }

    public static void Question()
	{
		Console.WriteLine("Please Sign-In");
		Console.WriteLine();

		Console.Write("Enter full name: ");
		FullName = Console.ReadLine();

		Console.Write("Enter Id Number: ");
		IdNumber = Console.ReadLine();

		Console.Write("Enter username: ");
		UserName = Console.ReadLine();

		Console.Write("Enter password: ");
		Password = Console.ReadLine();

		LogIn.Question();
	}

}
