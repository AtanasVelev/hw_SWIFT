using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Задача 5:Напрате клас, който конвертира градуси от Целзий във Ференхайт.
namespace HW7_7
{
    class Program
    {
        static void Main(string[] args)
        {
            TemperatureConverter UsersTemperature = new TemperatureConverter();
            Console.WriteLine("Enter your temperature in 'F' ");
            UsersTemperature.DegreesF = Convert.ToDouble(Console.ReadLine());
            UsersTemperature.ConvertDegrees();
        }
    }
    class TemperatureConverter
    {
       private double degreesC;
       private double degreesF;

        public void ConvertDegrees()
        {
            degreesC = (degreesF - 32) * 5 / 9;
            Console.WriteLine(degreesC);
        }
       
        public double DegreesC
        {
            get { return this.degreesC; }
            set { this.degreesC = value; }
        }
        public double DegreesF
        {
            get { return this.degreesF; }
            set { this.degreesF = value; }
        }
    }
}
