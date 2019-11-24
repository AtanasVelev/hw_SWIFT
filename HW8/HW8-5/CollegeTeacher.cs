using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_5
{
    class CollegeTeacher:Teacher
    {
        private string nameOfCollege;
        public CollegeTeacher()
        {

        }
        public void IntroduceYourself(string name, string nameOfCollege)
        {
            this.nameOfCollege = nameOfCollege;
            Console.WriteLine($"My name is {name} and I am from {nameOfCollege} College!");
        }
        public string NameOfCollege
        {
            get { return this.nameOfCollege; }
            set { this.nameOfCollege = value; }
        }
    }
}
