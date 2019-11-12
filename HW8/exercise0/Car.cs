using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise0
{
    class Car:IComparable<Car>
    {
        public string Brand { get; set; }
        public int ManufactureYear { get; set; }

        public Car(string Brand, int ManufactureYear)
        {
            this.Brand = Brand;
            this.ManufactureYear = ManufactureYear;
        }
       public int CompareTo(Car other)
        {
            //  return Brand.CompareTo(other.Brand);
            return ManufactureYear.CompareTo(other.ManufactureYear);

        }
    }
}
