using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_5
{
// Създайте клас Teacher, който наследява Person и добавя наименование на предмет, по който преподава.
//Класа Teacher трябва да има поне 2 конструктора (с и без параметри). Класа Teacher трябва да има метод за проверка на домашни.
//Проверката на домашни е умение, което е типично не само за учителите, но и за лекторите.
//Класа Teacher трябва да има методи за поздрав за добър ден и довиждане.
    class Teacher:Person
    {
        private string teachingSubject;

        public Teacher()
        {

        }
        public Teacher(string teachingSubject)
        {
            this.teachingSubject = teachingSubject;
        }
        public string TeachingSubject
        {
            get { return this.teachingSubject; }
            set { this.teachingSubject = value; }
        }
        public void CheckHomework()
        {
            Console.WriteLine("Checking HW!");
        }
        public void Greet()
        {
            Console.WriteLine("Hello!");
        }
        public void GoodDay()
        {
            Console.WriteLine("Good day!");
        }
        public void SayGoodbye()
        {
            Console.WriteLine("Goodbye!");
        }
    }
}
