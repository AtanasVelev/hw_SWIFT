using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_5
{
    class SchoolTeacher : Teacher
    {
        private List<string> Classes;
        
        public SchoolTeacher()
        {
            this.Classes = new List<string>();
        }
        public SchoolTeacher(List<string> Classes)
        {
            this.Classes = Classes;
        }
        
      public void АddClasses(params string[] Classes)
        {
            foreach(string className in Classes)
            {
                this.Classes.Add(className);
            }
            
        }
        public void PrintClasses()
        {
            foreach(string allclasses in Classes)
            {
                Console.WriteLine(allclasses);
            }
        }
        public void HaveFunWithChildren()
        {
            Console.WriteLine("I'm having fun with the children!");
        }
      
       
        
    }
}
