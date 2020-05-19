using System;
using System.Collections.Generic;

namespace Gradebook
{

    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.addGrade(89.1);
            book.addGrade(90.4);
            book.addGrade(45.6);
            book.addGrade(36.5);
            book.showStatistics();
        }
    }



}
