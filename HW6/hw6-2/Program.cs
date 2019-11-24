using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw6_2
{
    class Program
    {
        //Напишете метод, който да приема 2 параметъра : единият е едномерен масив от цели числа, а другият
        //параметър е цяло число.
        //Нека се провери дали едномерният масив съдържа в някой от елементите си стойността, която е зададена във втория параметър;
        //Ако масива съдържа числото, нека се върне true като резултат, в противен случай да се върне false.
        static void Main(string[] args)
        {
            int[] arr2 = { 23, 6, 5, 7, 98, 45 };
            ArrAndNumber(arr2,45);
        }
        static bool ArrAndNumber(int[] arr, int a)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (a == arr[i])
                {
                    Console.WriteLine($" Number {a} is included in the array!");
                    return true;
                }
            }
            Console.WriteLine("No match has been found!");
            return false;
            
        }
    }
}
