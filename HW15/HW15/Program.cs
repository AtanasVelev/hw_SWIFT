using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15
{
    //Задача 1.Създайте си enum с всички месеци.
    //След това : Нека се подава номера на месеца през конзолата и в зависимост кой е номера да се принтира дадения месец.
    //Тоест ако подам 1 ше ми принтира Януари, ако подам 2 ще ми принтира Февруари и тн.
    class Program
    {
        public enum MonthsOfYear
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        public static void PrintMonthFromInput(int month)
        {
            if(month<1||month>12)
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            Console.WriteLine((MonthsOfYear)month);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number that corresponds to a month of the year:");
            int month = Convert.ToInt32(Console.ReadLine());
            PrintMonthFromInput(month);
        }
    }
}

