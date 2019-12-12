using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15_2
{
    class Program
    {
//        Задача 2.
//Направете enum с различните сезони - пролет, лято , есен , зима.
//Направете метод, който приема дата(използвайте DateTime) и връща кой е сезона.Примерно ако подадем 25.01.2018 да връща зима.
        public enum SeasonsType
        {
            
            Spring,
            Summer,
            Autumn,
            Winter
        }
        public static SeasonsType Seasons(DateTime date)
        {
            int doy = date.DayOfYear - Convert.ToInt32((DateTime.IsLeapYear(date.Year)) && date.DayOfYear > 59);
            if (doy < 80 || doy >= 355)
            {
                
                Console.WriteLine(SeasonsType.Winter);
                return SeasonsType.Winter;
            }

            if (doy >= 80 && doy < 172)
            {
                Console.WriteLine(SeasonsType.Spring);
                return SeasonsType.Spring;
            }

            if (doy >= 172 && doy < 266)
            {
                Console.WriteLine(SeasonsType.Summer);
                return SeasonsType.Summer;
            }

            else
            {
                Console.WriteLine(SeasonsType.Autumn);
                return SeasonsType.Autumn;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                DateTime newDate = new DateTime(1992, 6, 12);
                Seasons(newDate);
                DateTime invalidDate = new DateTime(100, 100, 100);
                Seasons(invalidDate);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Invalid input!");
            }

        }
    }
}
