/*
  Name: Sadia Ahmed
  Class: IGME.201
  Due Date: 10/07/2025
  Assignment: Grade Calculator
*/

using System;

namespace GradeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1) name
            string studentName = "Sadia Ahmed";

            // 2) Grades array 
            int[] grades = { 100, 92, 87, 200, -20, 52, 82, 75, 67, 88 };

            // 3) 
            Console.WriteLine($"Welcome, {studentName}!");
            Console.WriteLine("Here are your grades:");

            // sum for the average
            int sum = 0;

            // 4) Loop through grades 
            for (int i = 0; i < grades.Length; i++)
            {
                int g = grades[i];
                Console.WriteLine($"Grade {i + 1}: {g}");

                // If/else 
                if (g >= 90 && g <= 100)
                {
                    Console.WriteLine("This grade is an A!");
                    
                    if (g == 100)
                    {
                        Console.WriteLine("WOW! A perfect score!");
                    }
                }
                else if (g >= 80 && g <= 89)
                {
                    Console.WriteLine("This grade is a B.");
                }
                else if (g >= 70 && g <= 79)
                {
                    Console.WriteLine("This grade is a C.");
                }
                else if (g >= 65 && g <= 69)
                {
                    Console.WriteLine("This grade is a D.");
                }
                else if (g >= 0 && g <= 64)
                {
                    Console.WriteLine("This grade is an F.");
                }
                else
                {
                    Console.WriteLine("This is out of the range of 0-100. How did you even get this grade?");
                }

                //  sum for average
                sum += g;

                //space
                Console.WriteLine();
            }

            // 5)  display average 
            double average = sum / (double)grades.Length;
            Console.WriteLine($"Final average for {studentName}: {average:F2}");

            // 6) End message
            Console.WriteLine($"We have displayed all grades for {studentName}.");

            // debugging console open
            // Console.ReadLine();
        }
    }
}
