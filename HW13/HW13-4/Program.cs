using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13_4
{
    class Program
    {
        //4. Напишете програма , която да пълни в някаква структура числата от 1 до 50.
        //След това като използвате струткурата отпечатете числата в обратен ред.Коя структура бихте избрали в случая.
        //Ако се сетите за няколко варианта за решение ги напишете всичките.
        static void Main(string[] args)
        {
            Stack<int> newStack = new Stack<int>();
            for(int i=1;i<=50;i++)
            {
                newStack.Push(i);
            }
            foreach(int num in newStack)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
            Stack<int> revStack = new Stack<int>();
            while(newStack.Count>0)
            {
                revStack.Push(newStack.Pop());
            }
            foreach (int num in revStack)
            {
                Console.WriteLine(num);
            }

            //List<int> newList = new List<int>();
            //for (int i = 1; i <= 50; i++)
            //{
            //    newList.Add(i);
            //}

            //foreach (int num in newList)
            //{
            //    Console.WriteLine(num);
            //}

            //newList.Reverse();

            //foreach (int num in newList)
            //{
            //    Console.WriteLine(num);
            //}
        }
    }
}
