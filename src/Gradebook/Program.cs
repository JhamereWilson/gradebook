using System;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 12.7, 6.3, 6.11 };
            var result = 0.0;
            foreach (double number in numbers)
            {
                result += number; // number + number

            }
            Console.WriteLine("The result is " + result);
        }
    }
}
