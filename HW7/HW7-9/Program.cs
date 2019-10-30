using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Задача 7:Създайте клас Книга, която да има : брой страници, година на печат, автор, заглавие. Също да има методи Print -  
//който по подадена страница, ще принтира на конзолата, коя страница ще бъде разпечатана.
namespace HW7_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Book newBook = new Book(132, 1992, "Atanas", "myBook");
            newBook.Print();
        }
    }
    class Book
    {
        private int pagesNum;
        private int printYear;
        private string author;
        private string bookTitle;
        public Book(int pages, int printYear, string author, string bookTitle)
        {
            this.pagesNum = pages;
            this.printYear = printYear;
            this.author = author;
            this.bookTitle = bookTitle;
        }
        public void Print()
        {
            Console.WriteLine("Enter a page number:");

            int pageNum = Convert.ToInt32(Console.ReadLine());

            if (pageNum > 132)
            {
                Console.WriteLine($"This book doesn't have that many pages!");
            }
            else
            {
                Console.WriteLine($"You chose to print page number: {pageNum}");
            }
        }
        public int PagesNum
        {
            get { return this.pagesNum; }
            set { this.pagesNum = value; }
        }

        public int PrintYear
        {
            get { return this.printYear; }
            set { this.printYear = value; }
        }
        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }
        public string BookTitle
        {
            get { return this.bookTitle; }
            set { this.bookTitle = value; }
        }
    }
}
