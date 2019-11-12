using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_1
{
    class SchoolBook:Book
    {
        public int SchoolBookNumberOfPages { get; set; }
       
        public int NumberOfStudents{ get; set; }
        public string TeachersName { get; set; }

        public SchoolBook(int SchoolBookNumberOfPages, int NumberOfStudents, string TeachersName):base(32,1885)
        {
            this.SchoolBookNumberOfPages = SchoolBookNumberOfPages;
          
            this.NumberOfStudents = NumberOfStudents;
            this.TeachersName = TeachersName;
        }
        public void PrintGrades(int[]grades)
        {
            int sum = 0;
          foreach(int grade in grades)
            {
                sum += grade;
            }
            Console.WriteLine($"The averege grade is: {sum/grades.Length}");
        }
    }
}
