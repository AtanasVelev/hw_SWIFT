using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Задача 3: От лекцията създайте 10 инстанции на класа Person.За всяка инстанция задайте различни стойности на property-тa.
//Тези 10 инстанции ги запазете в един масив. Накрая обходете масива и принтирайте масива и принтирайте името и егн-то на всеки човек.
namespace HW7_5
{
    class Person
    {
        string name;
        long personalNum;
        static void Main(string[] args)
        {
           
            Person person1 = new Person("Ivan ", 323201283918);

            Person person2 = new Person("Pesho ", 33125534123);
            
            Person person3 = new Person("Mariika ", 3232323283918);
          
            Person person4 = new Person("Misho ", 32320123118);
    
            Person person5 = new Person("Stoyan ", 3235454918);
     
            Person person6 = new Person("Atanas", 32323123918);
       
            Person person7 = new Person("Kalinka ", 32331231283918);
        
            Person person8 = new Person("Siika ", 323201231918);
   
            Person person9 = new Person("Milka ", 323203218);
          
            Person person10 = new Person("Svoge ", 32323223918);
       
            Person[] P = new Person[10] { person1, person2, person3, person4, person5, person6,person7,person8,person9,person10 };
            foreach(var person in P)
            {
                person.PrintData();
                
            }
        }
        public Person(string name, long personalNum)
        {
            this.name = name;
            this.personalNum = personalNum;
        }
        public void PrintData()
        {
            Console.WriteLine("Object's name is:");
            Console.WriteLine($"{name}");
            Console.WriteLine("Person's ID is:");
            Console.WriteLine($"{personalNum}");
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public long PersonalNum
        {
            get { return this.personalNum; }
            set { this.personalNum = value; }
        }
    }
}
