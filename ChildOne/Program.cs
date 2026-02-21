using System;

class ProgramOne{

    public static void Main(string[]args){
        string name1 = "Russel Jeoff P. Sto. Tomas";
        string[] favSubject = new string[] {"Programming", "Math", "Science"};

       Console.WriteLine($"Name: {name1}");
       Console.WriteLine();
       Console.WriteLine($"Favorite Subjects:");
       Console.WriteLine(favSubject[0]);
       Console.WriteLine(favSubject[1]);
       Console.WriteLine(favSubject[2]);
       Console.WriteLine();
       Console.Write("Hello ");
       Console.Write("World");
       Console.WriteLine();
       Console.WriteLine();
       
       int age = 18;
       Console.WriteLine($"Your age is{age}");

       Console.WriteLine();
       Console.Write("What is your name?");
       string name2 = Console.ReadLine();
       Console.WriteLine($"Hi, {name2}");
       Console.WriteLine($"What's your age?");
       int age1 = Console.ReadLine();

    }
}