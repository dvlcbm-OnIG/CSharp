using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1 - Solve Area of Circle (outside calculation)");
        Console.WriteLine("2 - BMI (outside calculation)");
        Console.WriteLine("3 - Solve Area of Circle");
        Console.WriteLine("4 - BMI");
        Console.Write("Enter choice: ");

        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Enter radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = 3.14159 * (radius * radius);

            if (radius > 0)
            {
                Console.WriteLine($"Area: {area}");
            }
            else
            {
                Console.WriteLine("Invalid radius.");
            }
        }
        else if (choice == 2)
        {
            Console.Write("Enter weight (kg): ");
            double weight = Convert.ToDouble(Console.ReadLine());

            double discountedWeight = weight - 5;

            if (weight > 100)
            {
                Console.WriteLine($"New Weight: {discountedWeight}");
            }
            else
            {
                Console.WriteLine($"Weight is normal: {weight}");
            }
        }
        else if (choice == 3)
        {
            Console.Write("Enter radius: ");
            double Radius = Convert.ToDouble(Console.ReadLine());

            if (Radius > 0)
            {
                double Area = 3.14159 * (Radius * Radius);
                Console.WriteLine($"Area: {Area}");
            }
            else
            {
                Console.WriteLine("Invalid radius.");
            }
        }
        else if (choice == 4)
        {
            Console.Write("Enter weight (kg): ");
            double Weight = Convert.ToDouble(Console.ReadLine());

            if (Weight > 100)
            {
                double DiscountedWeight = Weight - 5;
                Console.WriteLine($"New Weight: {DiscountedWeight}");
            }
            else
            {
                Console.WriteLine($"Weight is normal: {Weight}");
            }
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
        Console.ReadKey();
    }
}
