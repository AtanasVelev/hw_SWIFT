using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13_6
{
    class Program
    {
        //6. Напишете програма, която обръща думите в едно изречение на обратно. Използвайте стек.          
        //Пример: I am from planet Earth
        //Решение: Earth planet from am I
        static void Main(string[] args)
        {
            Stack<string> newStack = new Stack<string>();
            newStack.Push("I");
            newStack.Push("am");
            newStack.Push("from");
            newStack.Push("planet");
            newStack.Push("Earth");

            foreach(string words in newStack)
            {
                Console.WriteLine(words);
            }

            Console.WriteLine();
            int count = newStack.Count;

            Stack<string> revString = new Stack<string>();

            for(int i =0;i<count;i++)
            {
                revString.Push(newStack.Pop());
            }
            foreach (string words in revString)
            {
                Console.WriteLine(words);
            }

           

        }
    }
}
