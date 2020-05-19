using System;
using System.Collections.Generic;


namespace Gradebook
{
    class Book
    {
        public Book()
        {
            grades = new List<double>();
        }

        public void addGrade(double grade)
        {
            grades.Add(grade);
        }

        public void showStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach (double grade in grades)
            {
                lowGrade = Math.Min(grade, lowGrade);
                highGrade = Math.Max(grade, highGrade);
                result += grade; // number + number

            }

            var average = result / grades.Count;

            Console.WriteLine("The result is " + result);
            Console.WriteLine($"The average grade is {average:N2}");
            Console.WriteLine($"The lowest grade is {lowGrade:N2}");
            Console.WriteLine($"The highest grade is {highGrade:N2}");

        }
        private List<double> grades;
    }
}