using System;

public static class Program
{
    // A void function performs a task when called and does not return any value.

    public static void SumOfFour()
    {
        Console.Write("Enter first number: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter third number: ");
        double c = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter fourth number: ");
        double d = Convert.ToDouble(Console.ReadLine());

        double sum = a + b + c + d;

        Console.WriteLine($"The sum of the four numbers is: {sum}");
    }

    public static void AverageOfFour()
    {
        Console.Write("Enter first number: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter third number: ");
        double c = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter fourth number: ");
        double d = Convert.ToDouble(Console.ReadLine());

        double average = (a + b + c + d) / 4;

        Console.WriteLine($"The average of the four numbers is: {average}");
    }

    public static void AreaOfCircle()
    {
        Console.Write("Enter the radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        double area = 3.14159 * radius * radius;

        Console.WriteLine($"The area of the circle is: {area}");
    }

    public static void Introduce()
    {
        Console.WriteLine("1. Sum of four numbers");
        Console.WriteLine("2. Average of four numbers");
        Console.WriteLine("3. Area of the Circle");
        Console.Write("Choice: ");

        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1 )
        {
            SumOfFour();
        }
        else if (choice == 2 )
        {
            AverageOfFour();
        }
        else if (choice == 3 )
        {
            AreaOfCircle();
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    public static void Main(string[] args)
    {
        Introduce();


        Console.ReadKey();//
    }
}
