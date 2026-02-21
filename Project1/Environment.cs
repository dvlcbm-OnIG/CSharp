using System;

namespace Project1
{
    public static class Environment
    { 
       public static void Introduce()
        {
            Console.WriteLine("Welcome to the Environment!");
            Console.WriteLine();

            Console.WriteLine($"Full Name: {SignIn.FullName}");   
            Console.WriteLine($"ID Number: {SignIn.IdNumber}");       
            Console.WriteLine($"Password: {SignIn.Password}");
        }
    }
    
}
