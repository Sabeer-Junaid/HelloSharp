using System;
					
public class Program
{
	public static void Main()
	{
		string choice = "Y";
		string grade;
		
		while(choice.ToUpper() == "Y")
		{
			Console.WriteLine("Enter Student Marks");
			int marks = Convert.ToInt32(Console.ReadLine());
			
			switch(marks / 10)
			{
				case 9:
					grade = "A+";
					break;
				case 8:
					grade = "A";
					break;
				case 7:
					grade = "B";
					break;
				case 6:
					grade = "C";
					break;
				case 5:
					grade = "D";
					break;
				default:
					grade = "you are fail";
					break;		
			}
			
			Console.WriteLine($"Your Final Grade is {grade}");
			Console.WriteLine("Do you want to find another student grades? Y or N");
			choice = Console.ReadLine();
			Console.WriteLine("Your processing ended here");
		}
		
	}
}
