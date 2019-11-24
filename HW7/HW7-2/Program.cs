using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Създайте нов клас, който да описва свойствата и характеристиките на обекта Автомобил.Кръстете си класа "Car" и го добавете
//в namespace "Vehicles". Колата нека има като характеристики следните неща: model, brand, registrationNumber, color, years, seatsNumber
//- isDiesel(bool).Добавете си и един метод в класа, който да изпринтира на конзолата всичките свойства на колата.
//След като сте създали класа, пробвайте да го извикате от Main метода, като си създадете инстанция от този клас и 
//му зададете някакви стойности. пример : Car car1 = new Car(); car.Model = "Peugeout"; car.Brand = "206";и тн...

        
 namespace Vehicles
 {
    class Program
    {
        static void Main(string[] args)
        {
            Car NewCar = new Car("Civic", "Honda", "PA7832BT", "blue", 9,5,isDiesel:true);
            NewCar.Print();
            Car NewCar2 = new Car();
            Console.WriteLine();
            NewCar2.Model = "M6";
            NewCar2.Brand = "BMW";
            NewCar2.Print();
        }
    }

    class Car
    {
            private string model;
            private string brand;
            private string registrationNumber;
            private string colour;
            private int years;
            private int seatsNumber;
            private bool isDiesel;
        public void Print()
        {
            Console.WriteLine($"This car has the following characteristics:\n Model: {model}\n Brand:{brand}\n RegNumber:{registrationNumber},\n " +
                $"Colour:{colour}\n Years:{years}\n Number of Seats:{seatsNumber}\n Diesel:{isDiesel}");
        }
        public Car()
        {

        }
        public Car(string model, string brand,string registrationNumber, string colour, int years, int seatsNumber, bool isDiesel)
        {
            this.model = model;
            this.brand = brand;
            this.registrationNumber = registrationNumber;
            this.colour = colour;
            this.years = years;
            this.seatsNumber = seatsNumber;
            this.isDiesel = true;
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public string Brand
        {
            get { return this.brand; }
            set { this.brand = value; }
        }
        public string RegistrationNumber
        {
            get { return this.registrationNumber; }
            set { this.registrationNumber = value; }
        }
        public string Colour
        {
            get { return this.colour; }
            set { this.colour = value; }
        }
        public int Years
        {
            get { return this.years; }
            set { this.years = value; }
        }
        public int SeatsNumber
        {
            get { return this.seatsNumber; }
            set
            {
                if(value<0)
                {
                    Console.WriteLine("Invalid Input");
                }
                else
                {
                    this.seatsNumber = value;
                }
            }
        }
        public bool IsDiesel
        {
            get { return this.isDiesel; }
            set { this.isDiesel= value; }
        }
    }
 }
