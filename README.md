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

<a href = "https://github.com/Sabeer-Junaid/HelloSharp/blob/main/Problems/Print%20Bio%20data%20by%20using%20escape%20sequence.cs">Simple Bio Data Collector</a>

<details>
<summary>Objective</summary>
  
1. The program prompts the user to input their **first name**, **father's name**, **age**, and **occupation**.  
2. The user is asked to confirm if the details they provided are correct by typing "Y" or "N".  
3. If the user confirms with "Y", the program displays the entered details:  
   - Name  
   - Father's name  
   - Age  
   - Occupation  
4. If the user responds with "N", the program cancels the procedure and informs the user.  
5. The program uses basic input/output functionality with `Console.ReadLine()` and `Console.WriteLine()` for interaction.
   
</details>

<a href = "https://github.com/Sabeer-Junaid/HelloSharp/blob/main/Problems/Grade%20Determine%20using%20If-Else.cs">Grade Evaluation Based on Subject Marks using If-Else</a>

<details>
  
  1. The program prompts the user to enter their subject marks, with a valid range between 0 and 100.  
2. If the marks entered are outside the valid range, the program displays an error message.  
3. If the marks are valid, the program calls the `GetGrade()` method to determine the grade based on the marks.  
4. The `GetGrade()` method assigns the grade according to the following ranges:  
   - `81-100` → "A+"  
   - `71-80` → "A"  
   - `61-70` → "B"  
   - `51-60` → "C"  
   - `41-50` → "D"  
   - `0-40` → "Unfortunately, you didn't make it."  
5. The program displays the corresponding grade to the user.  
  
</details>
