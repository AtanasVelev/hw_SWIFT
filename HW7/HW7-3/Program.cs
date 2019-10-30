using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Дефинирайте клас Person, който да има име, години и e-mail.Капсулирайте полетата на класа. Име.Години.Еmail
//Дефинирайте функция, която извежда в конзолата данните на човека.Направете 3 обекта от тип Person и демонстрирайте функциите на класа.
namespace HW7_3
{
   public class Person
    {
        static void Main(string[] args)
        {
            Person NewPerson = new Person();
            NewPerson.name = "Ivan";
            NewPerson.age = 32;
            NewPerson.email = "ivan@abv.bg";

            NewPerson.PrintPersonData();
        }

        private  string name;
        private  int age;
        private  string email;
       
        public void PrintPersonData()
        {
            Console.WriteLine(name + " " + age + " " + email + " ");
        }
        public string Name
        {
            get { return  this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
    }
}
