using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    class FighterJet:Airplane
    {
        private int missilesNum;
        public FighterJet():base()
        {
            
        }
        public int MissilesNum
        {
            get { return this.missilesNum; }
            set { missilesNum = value; }
        }
           

    }
}
