using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13_3
{
    class Bike
    {
        private string brand;
        private string model;
        private string color;
        public Bike(string Brand, string Model, string Color)
        {
            this.brand = Brand;
            this.model = Model;
            this.color = Color;
        }
        public string Brand
        {
            get { return this.brand;}
            set { this.brand = value; }
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
    }
}
