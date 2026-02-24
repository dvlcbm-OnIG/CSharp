using System;

class ProgramTwo{

    public static void Main(string[]args){
        string name1 = "Russel Jeoff P. Sto. Tomas";
       Console.WriteLine($"Name: {name1}");
       Console.WriteLine();

       Console.WriteLine("Favorite Subjects:");
       Console.WriteLine("Programming");
       Console.WriteLine("Math");
       Console.WriteLine("Science");
       Console.WriteLine();

       Console.Write("Hello "); Console.Write("World");
       Console.WriteLine();
       Console.WriteLine();
       
       int age = 18;
       Console.WriteLine($"Your age is{age}");
       Console.WriteLine();

       Console.Write("What is your name?");
       string name2 = Console.ReadLine();
       Console.WriteLine($"Hello, {name2}!");
       Console.WriteLine($"What's your age?");
       string age1 = Console.ReadLine();
       Console.WriteLine($"You are {age1} years old");
       Console.WriteLine();
       Console.WriteLine();

       Console.Write("Enter first number: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNum = int.Parse(Console.ReadLine());

      int result1 = firstNum + secondNum;
      Console.WriteLine($"Sum: {result1}");

      Console.Write("What is you favorite color?");
      string favColor = Console.ReadLine();
      Console.WriteLine($"Your favorite color is {favColor}");
      Console.WriteLine();

      string name3 = "Russel";
      string age2 = "18";

      Console.WriteLine($"Name: {name3}, Age; {age2}");

      Console.Write("What's your name?");
      string name4 = Console.ReadLine();
      Console.Write("What's your age?");
      string age3 = Console.ReadLine();
      Console.Write("What's your city?");
      string city1 = Console.ReadLine();

      Console.WriteLine($"Hello {name4}, you are {age3} years old and live in {city1}.");

    }
}