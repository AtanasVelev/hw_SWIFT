using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise0
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = 
                {
                new Car("bmw",1992),
                new Car("mercedes",1999),
                new Car("porsche",2000),
                new Car("lada",1989),
                new Car("honda",2006),
                new Car("suziki",2015)
                };
            Array.Sort(cars);
            foreach(Car car in cars)
            {
                Console.WriteLine(car.Brand + " " + car.ManufactureYear);
            }
        }
    }
}
