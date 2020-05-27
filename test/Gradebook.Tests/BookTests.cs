using System;
using Xunit;

namespace Gradebook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            // arrange
            var book = new Book("");
            book.addGrade(80.0);
            book.addGrade(70.0);

            //act
            // book.showStatistics();
            //assert

        }
    }
}
