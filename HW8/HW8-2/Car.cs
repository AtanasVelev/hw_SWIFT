using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_2
{
    class Car : ICar
    {
        public  string Name { get; set; }
        public int ManufactureYear { get; set; }
        public string CarId { get; set; }
        public string Engine{get; set;}
        public int NumberOfTires { get; set; }
        public Car(string Name, int ManufactureYear, string CarId,string Engine,int NumberOfTires)
        {
            this.Name = Name;
            this.ManufactureYear = ManufactureYear;
            this.CarId = CarId;
            this.Engine = Engine;
            this.NumberOfTires = NumberOfTires;
        }
        public void StartTurbo()
        {
            Console.WriteLine("Turbo is ON!");
        }
        public void PrintCarInfo()
        {
            Console.WriteLine($"Name: {Name} \nManufactureYear: {ManufactureYear} \nCarID: {CarId} \nEngine: {Engine} \nNumber of tires: {NumberOfTires}");
        }
        public void Drive(int speed)
        {
            Console.WriteLine($"Your current speed is {speed} km/h");
        }
        public void GetYears(int currentYear)
        {
            int carAge;
            carAge = currentYear - ManufactureYear;
            Console.WriteLine($"Your car's age is: {carAge}");
        }
    }
}
