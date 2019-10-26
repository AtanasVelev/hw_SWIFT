using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_4
{
    class Program
    {
        //Да се състави програма, която извежда сумата на всички числа от интервала 1 до въведено от конзолата
        //число.Числото трябва да е в интервала[10 – 100].
        //Използвайте рекурсия за решението на задачата.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 10-100:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 10 || n > 100)
            {
                Console.WriteLine("Your number is out of range");
            }
            else
            {
                Console.WriteLine(SumOfNumbers(n));
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        static int SumOfNumbers(int n)
        {
            if (n <= 1)
            {
                return 1;
            }

            return n + SumOfNumbers(n - 1);
        }


    }
}
