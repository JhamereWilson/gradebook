using System;
using System.Collections.Generic;

namespace Gradebook
{

    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("testBook");
            book.addGrade(89.1);
            book.addGrade(90.4);
            book.addGrade(45.6);
            book.addGrade(36.5);
            var stats = book.getStatistics();
            Console.WriteLine($"The average grade is {stats.Average:N2}");
            Console.WriteLine($"The lowest grade is {stats.Low:N2}");
            Console.WriteLine($"The highest grade is {stats.High:N2}");
        }
    }



}
