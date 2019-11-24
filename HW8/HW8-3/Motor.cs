using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_3
{
    class Motor:ICar
    {
        public override int ManufactureYear { get { return 1; } }
        public Motor():base("Suzuki",2006,"fafs4","fdr54")
        {

        }
        public override void Drive(int speed)
        {
            Console.WriteLine($"Speed is at {speed} km/h");
        }
        public override void GetYears(int currentYear)
        {
            int motorAge;
            motorAge = currentYear - ManufactureYear;
            Console.WriteLine($"Your motor's age is {motorAge} years");
        }
    }
}
