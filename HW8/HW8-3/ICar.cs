using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_3
{
    abstract class ICar
    {
       public string Name { get; set; }
       public virtual int ManufactureYear { get; set; }
        string CarId { get; set; }
        string Engine { get; set; }
        public ICar(string Name, int ManufactureYear, string CardID, string Engine)
        {
            this.Name = Name;
            this.ManufactureYear = ManufactureYear;
            this.CarId = CardID;
            this.Engine = Engine;
            this.Engine = Engine;
        }
        public abstract void Drive(int speed);

        public abstract void GetYears(int currentYear);
    }
}
