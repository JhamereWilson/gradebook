using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 12.7, 6.3, 6.11 };
            var grades = new List<double>() { 12.7, 6.3, 6.11 }; //instantiate a list like a class -> a list is an object
           
         
            var result = 0.0;
            foreach (double grade in grades)
            {
                result += grade; // number + number

            }

            var average = result / grades.Count;
             
            Console.WriteLine("The result is " + result);
            Console.WriteLine("The average is " + average);
            
        }
    }
}
