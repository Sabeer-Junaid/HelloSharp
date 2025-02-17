<a href = "https://github.com/Sabeer-Junaid/HelloSharp/blob/main/Problems/Subjects%20Average.cs">Calculating and Rounding the Average of Subject Marks in C#</a>
<details>
  <summary>Objective</summary>
  
1. The program prompts the user to enter marks for three subjects: English, Math, and Urdu.  
2. It reads the user input and converts the values from string to integer using `Convert.ToInt32()`.  
3. The total marks are calculated by summing up the three subject marks.  
4. The program calls the `Avg()` method, passing the total marks and the number of subjects (3) as arguments.  
5. The `Avg()` method calculates the average by dividing the total marks by the number of subjects and returns a `double` value.  
6. The average is rounded to the nearest whole number using `Math.Round()`.  
7. The final rounded average is displayed on the console using `Console`
  
</details>

<a href = "https://github.com/Sabeer-Junaid/HelloSharp/blob/main/Problems/StudentGradeUsingSwitch.cs">Student Grade Calculator Using Switch</a>

<details>
  <summary>Objective</summary>
  
1. The program initializes a `choice` variable to "Y" and a `grade` variable to store the final grade.  
2. It enters a `while` loop that continues as long as the user inputs "Y" (case insensitive).  
3. The program prompts the user to enter student marks and converts the input into an integer.  
4. A `switch` statement determines the grade based on the tens place of the entered marks:  
   - `90-100` → "A+"  
   - `80-89` → "A"  
   - `70-79` → "B"  
   - `60-69` → "C"  
   - `50-59` → "D"  
   - Below `50` → "You are fail"  
5. The program displays the final grade.  
6. It asks the user if they want to check another student's grade.  
7. If the user inputs "Y," the process repeats; otherwise, the program ends.  

</details>
