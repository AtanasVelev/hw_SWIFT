using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_3
{
    class Program
    {
        //Напишете метод, който приема две числа.
        //Нека в метода се проверява дали числата са равни.Да се върне булева променлива с резултата дали
        //числата са равни или не.
        static void Main(string[] args)
        {
            CompareNumbers(5, 5);
        }

        static bool CompareNumbers(int a, int b)
        {
            if (a==b)
            {
                Console.WriteLine("The numbers are equal!");
                return true;
                
            }
            Console.WriteLine("The numbers are NOT equal!");
            return false;
            
        }
    }
}
