using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Задача 6: Създайте клас Библиотека, като тя да има локация, големина, година на отваряне.
namespace HW7_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Library MyLibrary = new Library("Sofia",45,1992);
            MyLibrary.PrintLibraryDetails();
        }
    }
    class Library
    {
        private string location;
        private int size;
        private int openingYear;

        public Library(string location,int size, int openingYear)
        {
            this.location = location;
            this.size = size;
            this.openingYear = openingYear;
        }

        public void PrintLibraryDetails()
        {
            Console.WriteLine($"Library Details:");
            Console.WriteLine($"Location: {location}");
            Console.WriteLine($"Size in m3: {size}");
            Console.WriteLine($"Opening Year: {openingYear}");
        }
        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }
        public int Size
        {
            get { return this.size; }
            set { this.size = value; }
        }
        public int OpeningYear
        {
            get { return this.openingYear; }
            set { this.openingYear = value; }
        }
    }
}
