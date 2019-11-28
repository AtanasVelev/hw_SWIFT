using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13_5
{
    class Program
    {
        //5. Създайте си структурата опашка и я напълнете с числата от 1 до 10.
        //След това обходете опашката и изтрийте елементите, докато текущия елемент не стане равен на числото 5. Когато стане 5 принтирайте, 
        //че това е което търсите и спрете обхождането.


        static void Main(string[] args)
        {
            Queue<int> newQueue = new Queue<int>();
            for (int i = 1; i <= 10; i++)
            {
                newQueue.Enqueue(i);
            }

            //foreach (int num in newQueue)
            //{
            //    Console.WriteLine(num);
            //}
            int index = 0;
            while(newQueue.Count>0)
            {
                int current = newQueue.Dequeue();
                index++;
                if (current==5)
                {
                    Console.WriteLine("Job is done!");
                    return;
                }
                Console.WriteLine(current);
            }
            foreach (int num in newQueue)
            {
                Console.WriteLine(num);
            }
        }
    }

}
