using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_4
{
   public class Animal:IComparable<Animal>
    {
        public string TypeOfAnimal { get; set; }
        public int AgeOfAnimal { get; set; }
        public Animal(string TypeOfAnimal, int AgeOfAnimal)
        {
            this.TypeOfAnimal = TypeOfAnimal;
            this.AgeOfAnimal = AgeOfAnimal;
        }
       public int CompareTo(Animal other)
        {
            return TypeOfAnimal.CompareTo(other.TypeOfAnimal);
        }
        public void Speak()
        {
            Console.WriteLine($"I am a {TypeOfAnimal} and I am {AgeOfAnimal} years old!");
        }
    }
}
