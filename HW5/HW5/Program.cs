using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Напишете програма, която намира най - голямото число от дадени 10 произволни числа(може да си ги зададете в масив)

            Console.WriteLine("Choose the length of the array and add the elements:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for(int i =0; i<n;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int smallest = arr[0];
            for (int i = 0; i < n; i++)

            {
                if (arr[i] < smallest)
                {
                    smallest = arr[i];
                }
            }
                int largest = arr[n-1];
                for (int i = 0; i < n; i++)
                {

                    if (arr[i] > largest)
                    {
                        largest = arr[i];

                    }
                }
            Console.WriteLine($"the smallest no is {smallest}");
            Console.WriteLine($"the largest no is {largest}"); 
        }
    }
}
