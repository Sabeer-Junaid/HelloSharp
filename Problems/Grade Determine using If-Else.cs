using System;

public class HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Write your Subject Mark (0 - 100): ");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks < 0 || marks > 100)
            {
                Console.WriteLine("Invalid input. Marks should be between 0 and 100.");
            }
            else
            {
                string grade = GetGrade(marks);
                Console.WriteLine($"\nYour Grade is: {grade}");
            }
        }

        public static string GetGrade(int marks)
        {
            if (marks > 80) return "A+";
            else if (marks > 70) return "A";
            else if (marks > 60) return "B";
            else if (marks > 50) return "C";
            else if (marks > 40) return "D";
            else return "Unfortunately, you didn't make it.";
        }
    }
}
