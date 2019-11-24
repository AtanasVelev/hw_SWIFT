using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    class PassengerPlane:Airplane
    {
        private int passengerNum;
        public PassengerPlane():base()
        {
            
        }
        public int PassengerNum
        {
            get { return this.passengerNum; }
            set { this.passengerNum = value; }
        }
    }
}
