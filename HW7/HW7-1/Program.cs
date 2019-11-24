using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Задача 1:Създайте клас мотор, който да има следните характеристики : модел, цвят, година на производство, максимална скорост.
//Създайте няколко инстанции на този клас мотор.
namespace HW7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MotorBike Motor1 = new MotorBike("Honda","Blue",1992,156);
            Motor1.Print();
            Console.WriteLine("");
            MotorBike Motor2 = new MotorBike();
            Motor2.Model = "Suzuki";
            Motor2.Colour = "Red";
            Motor2.Year = 1880;
            Motor2.MaxSpeed = 166;
            Motor2.Print();
            Console.WriteLine("");

            //MotorBike Motor3 = new MotorBike();

            // MotorBike Motor4 = new MotorBike();
        }
    }
    class MotorBike
    {
        private string model;
        private string colour;
        private int year;
        private int maxSpeed;

       public MotorBike(string model, string colour, int year, int maxSpeed)
        {
           this.model = model;
           this.colour = colour;
           this.year = year;
           this.maxSpeed = maxSpeed;
        }
        public MotorBike()
        {

        }
        public void Print()
        {
            Console.WriteLine($" Model:{model}, Colour:{colour}, Year:{year}, MaxSpeed:{maxSpeed}");
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }
        public string Colour
        {
            get
            {
                return this.colour;
            }
            set
            {
                this.colour = value;
            }
        }
        public int Year
        {
            get
            {
                return this.year;
            }
            set
            {
                this.year = value;
            }
        }
        public int MaxSpeed
        {
            get
            {
                return this.maxSpeed;
            }
            set
            {
                this.maxSpeed = value;
            }
        }
    }
       
}
