using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13_2
{
    class Program
    {
        //2. Напишете си клас Car и му задайте да има следните свойства: Brand, Model, RegisterNumber и SeatsNumber.
        //Направете си няколко инстанции от коли и ги добавете в списък от Коли.
        //Обходете списъка и принтирайте подробна информация за колите.
        static void Main(string[] args)
        {
            Car newCar1 = new Car("BMW", "M5", "PA7865BT", 3);
            Car newCar2 = new Car("Honda", "Accord", "PA7113BT", 4);
            Car newCar3 = new Car("Mercedes", "GL", "PA3333BT", 5);
            Car newCar4 = new Car("Suzuki", "Puma", "PA3212BT", 6);

            List<Car> carsList = new List<Car>();

            carsList.Add(newCar1);
            carsList.Add(newCar2);
            carsList.Add(newCar3);
            carsList.Add(newCar4);

            Console.WriteLine($"CARS INFO\n");
            foreach (Car car in carsList)
            {
                Console.WriteLine($"Brand:{car.Brand}\nModel:{car.Model}\nRegNum:{car.RegNumber}\nSeatsNum:{car.SeatsNumber}\n");
            }
        }
    }
}
