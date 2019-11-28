using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13_7
{
    class Program
    {
        ////7. Напишете програма, която маха определени думи (по-къси от 3 символа) от изречение Използвайте опашка.               
        //Пример: My spaceship is ready for travelling to Mars
        //Решение: spaceship ready travelling Mars
        static void Main(string[] args)
        {
            Queue<string> newQueue = new Queue<string>();

            newQueue.Enqueue("My");
            newQueue.Enqueue("spaceship");
            newQueue.Enqueue("is");
            newQueue.Enqueue("ready");
            newQueue.Enqueue("for");
            newQueue.Enqueue("travelling");
            newQueue.Enqueue("to");
            newQueue.Enqueue("Mars");
            
                int index = 0;
                
                while (newQueue.Count>0)
                {
                    
                    if (newQueue.ElementAt(index).ToString().Length > 3)
                    {
                        Console.WriteLine(newQueue.ElementAt(index));
                    }

                    newQueue.Dequeue();

                }
           
           
        }

    
}
}
