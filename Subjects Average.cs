using System;

public class Program
{
    public static void Main()
    {


        Console.WriteLine("Enter English Marks");
        int sub1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Math Marks");
        int sub2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Urdu Marks");
        int sub3 = Convert.ToInt32(Console.ReadLine());

        int total = sub1 + sub2 + sub3;
        double average = Avg(total, 3);
        double roundedavg = Math.Round(average);
        Console.WriteLine($"Subjects Average is {roundedavg}");


    }

    public static double Avg(int total, int subjects)
    {
        return (double)total / subjects;
    }
}