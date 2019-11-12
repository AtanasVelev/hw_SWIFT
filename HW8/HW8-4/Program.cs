using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_4
{
//3. Прочетете и ги напишете на програма дадените примери тук за вградените интерфейси в.NET framework-a.

//https://support.microsoft.com/en-us/kb/320727

//https://msdn.microsoft.com/en-us/library/system.idisposable%28v=vs.110%29.aspx
    class Program
    {
        static void Main()
        {
            Animal Dog = new Animal("Dog", 3);
            //Dog.Speak();

            Animal[] animals = { new Animal("Dinosaur",100), new Animal("Cat", 3), new Animal("Bird", 1), new Animal("Cow", 5), new Animal("Racoon", 7) };

            //foreach(Animal animal in animals)
            //{
            //    animal.Speak();
            //}
            //Array.Sort(animals);
            Array.Sort(animals, new CompareByAge());

            foreach(Animal animal in animals)
            {
                Console.WriteLine(animal.TypeOfAnimal + " " + animal.AgeOfAnimal);

            }
            
        }
    }
}
