using System;
using System.Collections.Generic;


namespace Gradebook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void addGrade(double grade)
        {
            grades.Add(grade);
        }

        // public void showStatistics(Statistics stats)
        // {
        //     Console.WriteLine($"The average grade is {stats.Average:N2}");
        //     Console.WriteLine($"The lowest grade is {stats.Low:N2}");
        //     Console.WriteLine($"The highest grade is {stats.High:N2}");
        // }

        public Statistics getStatistics() // return a statistics object 
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach (double grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade; // number + number

            }

            result.Average/= grades.Count;
            return result;

        }
        private List<double> grades;
        private String name;
    }
}