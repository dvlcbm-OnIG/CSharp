using System;
using System.Globalization;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("first num: ");
        int Fnum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("second num");
        int Snum = Convert.ToInt32(Console.ReadLine());

        int Sum = Fnum + Snum;

        Console.WriteLine($"Sum: {Sum}");

        Console.ReadKey();
    }
}