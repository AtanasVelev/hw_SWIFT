using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    class Airplane
    {
        public delegate void SpeedOverThresholdHandler();
        public event SpeedOverThresholdHandler SpeedOverThreshold;

        public delegate void HeightOverThresholdHandler();
        public event HeightOverThresholdHandler HeightOverThreshold;

        private int currentSpeed;
        private int currentHeight;

        
        public virtual int CurrentSpeed
        {
            get { return this.currentSpeed; }
            set {
                this.currentSpeed = value;
                if (value > 300)
                {
                    SpeedOverThreshold.Invoke();
                }
                   
                }
        }
        public virtual int CurrentHeight
        {
            get { return this.currentHeight; }
            set
            {
                this.currentHeight = value;
                if (value > 10000)
                {
                    HeightOverThreshold.Invoke();
                }
                

            }

        }
        public Airplane()
        { }
    }
 }

