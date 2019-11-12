using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_3
{
    //2. Направете нов проект - интерфейса от задача 1) го заменете с абстрактен клас.
    //Създайте си класовете Кола и Мотор(пак както са описани горе), но този път да наследяват абстрактния клас.
    class Program
    {
        static void Main(string[] args)
        {
            Car newCar = new Car(4);
            newCar.Drive(213);
            newCar.GetYears(2020);
            newCar.StartTurbo();

            Motor newMotor = new Motor();
            Console.WriteLine(newMotor.ManufactureYear);
            newMotor.Drive(545);
            newMotor.GetYears(2030);
        }
    }
}
