using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_1
{
    class Book
    {
        public int NumberOfPages { get; set; }
        public int PrintYear { get; set; }
        
        public Book(int NumberOfPages, int PrintYear)
        {
            this.NumberOfPages = NumberOfPages;
            this.PrintYear = PrintYear;
           
        }
        public void PrintPage(int pagenum)
        {
            Console.WriteLine($"You chose to print page number: {pagenum}");
        }
    }
}
