using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book(132,1992);
            book.PrintPage(32);
            Console.WriteLine($"Print Years is {book.PrintYear}");

            SchoolBook schoolBook = new SchoolBook(101,32,"Ivan");
            schoolBook.PrintGrades(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine($"The name of the teacher is: {schoolBook.TeachersName}");
            Console.WriteLine($"The Print Year is: {schoolBook.PrintYear}");
            Novel novel = new Novel("gosho","goodbook");
            novel.PrintGrades(new[] { 34, 32, 31, 1 });
        }
    }
  
    
}
