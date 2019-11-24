using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_2
{
    class Motor:ICar
    {
        public string Name { get; set; }
        public int ManufactureYear { get; set; }
        public string CarId { get; set; }
        public string Engine { get; set; }

        public Motor(int ManufactureYear)
        {
            this.ManufactureYear = ManufactureYear;
        }
        public void Drive(int speed)
        { }
        public void GetYears(int currentYear)
        {
            int motorAge;
            motorAge = currentYear - ManufactureYear;
            Console.WriteLine($"Your motor's age is: {motorAge}");
        }
        
    }
}
