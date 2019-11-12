using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_5
{
  // Създайте клас Person, който има име, фамилия и години трудов стаж.Нека полетата да са скрити за всички, освен за наследниците, 
  //и манипулациите да се извършват, чрез пропъртита. Класа Person НЕ трябва да може да се инстанцира.
   abstract class Person
    {
      protected string firstName;
      protected string lastName;
      protected int workExperience;
      public static int personCount = 0;
       
        protected  Person()
        {
            
            personCount += 1;
        }
        protected Person(string firstName, string lastName, int workExperience)
        {
            this.firstName = firstName; this.lastName = lastName;this.workExperience = workExperience;
            personCount += 1;
        }


        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public int WorkExperience
        {
            get
            {
                if (workExperience < 0)
                {
                    
                    return 0;
                    
                }
                else
                    return this.workExperience;
                 }
            set { this.workExperience = value; }
        }
    }
}
