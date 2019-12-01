using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13
{
    class Program
    {
 //1 Направете програма, която: Да пълни числата от 1 до 100 в списък. След това обходете списъка и изтриите всички числа, които завършват на 0 (10, 20, 30 и т.н.)
        static void Main(string[] args)
        {
            List<int> numbersList = new List<int>();

            for (int i = 0; i <= 100; i++)
            {
                numbersList.Add(i);
            }

            //foreach(int number in numbersList)
            //{
            //    Console.WriteLine(number);
            //}
            
            for(int i=0;i<=numbersList.Count;i++)
            {
                
                if (numbersList.ElementAt(i)%10==0)
                {
                    numbersList.Remove(numbersList.ElementAt(i));
                }
                
            }
            foreach (int number in numbersList)
            {
                Console.WriteLine(number);
            }

        }
    }
}
