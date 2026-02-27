using System;

public class Program
{
    public static int Gwa(int sum, int attmp)
    {
        return sum / attmp;
    }
    public static void Main(string[] args)
    {

        int summing = 0;
        int grade;
        int subject = 1;
        int attempt = 0; //i put -1 instead of 0 to decrease the divisor avoid the 0 input from being included in the getting the average

        do
        {
            Console.Write($"Enter grade #{subject} (enter '0' to stop): ");
            grade = Convert.ToInt32(Console.ReadLine());


            if(grade != 0){
            summing += grade;
            attempt++;
            subject++;
            }

        }while (grade != 0);
           int GWA = Gwa(summing, attempt);
           Console.WriteLine($"your GWA is {GWA}%");

        string status;
        if (GWA >= 75)
        {
            status = "Passed";
        }
        else
        {
            status = "Failed!";
        }

        Console.WriteLine($"Status: {status}");

            Console.ReadKey();

    }

}

