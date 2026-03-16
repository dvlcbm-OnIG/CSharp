using System;

public static class Program
{
    //get the average of four numbers using void method

    public static double AverageOfFour(double a, double b, double c, double d)
    {
        double result = (a + b + c + d) / 4; //calculations
        return result; //return the result to the function
    }
    public static void Main(string[] args)
    {

        Console.WriteLine(AverageOfFour(75, 75, 75, 75)); //calling the function and giving it values

        Console.ReadKey();
    }
}