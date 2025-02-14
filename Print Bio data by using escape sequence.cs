using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5


 namespace Dcoder
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       Console.WriteLine("::: BIO DATA :::");
          
       Console.WriteLine("\nWrite your First Name:");
       string name = Console.ReadLine();
       Console.WriteLine("\nWrite your Father Name");
       string fname = Console.ReadLine();
       Console.WriteLine("\nWrite your Age");
       int age = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("\nWrite your Occupation");
       string occup = Console.ReadLine();
       
       Console.WriteLine("\nAre you sure about the details you provided is correct? Y or N");
       string confirm = Console.ReadLine();
       if (confirm == "Y")
       {
         Console.WriteLine($"\tyour name is {name}");
         Console.WriteLine($"\tyour father name is {fname}");
         Console.WriteLine($"\tyour age is {age}");
         Console.WriteLine($"\tyour occup is {occup}");
       }
       else if (confirm == "N")
       {
         Console.WriteLine("procedure canceld");
       }
   
     }
   }
 }
