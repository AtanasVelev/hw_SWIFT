using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13_2
{
    class Car
    {
        private string brand;
        private string model;
        private string regNumber;
        private int seatsNumber;

        public Car(string Brand, string Model, string RegNumber, int SeatsNumber)
        {
            this.brand = Brand;
            this.model = Model;
            this.regNumber = RegNumber;
            this.seatsNumber = SeatsNumber;

        }
        public string Brand
        {
            get { return this.brand; }
            set { this.brand = value; }
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public string RegNumber
        {
            get { return this.regNumber; }
            set { this.regNumber = value; }
        }
        public int SeatsNumber
        {
            get { return this.seatsNumber; }
            set { this.seatsNumber = value; }
        }
    }
}
