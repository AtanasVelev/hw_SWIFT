using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    class Converter
    {
        public delegate void ThresholdReachedHandler();
        public event ThresholdReachedHandler ThresholdReached;
        public Converter()
        {
        }
        public decimal  ConvertToEuro(decimal dollarsAmount)
        {
            decimal result;
            if(dollarsAmount>10000)
            {
                ThresholdReached.Invoke();
            }
            result = dollarsAmount * (decimal)0.91;
            return result;
        }
        public decimal ConvertToDollars(decimal euroAmount)
        {
            decimal result;
            if (euroAmount > 10000)
            {
                ThresholdReached.Invoke();
            }
            result = euroAmount * (decimal)1.10;
            return result;
        }
    }
}
