using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_2
{
    public interface ICar
    {
        string Name { get; set; }
        int ManufactureYear { get; set; }
        string CarId { get; set; }
        string Engine { get; set; }
        void Drive(int speed);
        
        void GetYears(int currentYear);

    }
}
