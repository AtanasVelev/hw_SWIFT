using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_3
{
   class Car:ICar
    {
        public int NumberOfTires { get; set; }
        public Car(int NumberOfTires):base("BMW",1992,"PA5354BT","AEWQ42")
        {
            this.NumberOfTires = NumberOfTires;
        }
        public void StartTurbo()
        {
            Console.WriteLine("Turbo is ON!!!");
        }
      public override void Drive(int speed)
        {
            Console.WriteLine($"Your current speed is {speed} km/h");
        }
        public override void GetYears(int currentYear)
        {
            int carAGE;
            carAGE = currentYear - ManufactureYear;
            Console.WriteLine($"Your car's age is {carAGE} years");
        }
    }
}
