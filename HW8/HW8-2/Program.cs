using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_2
{
    // 1. Създайте интерфейс за Моторно Превозно средство - той трябва задължително да има свойствата име, година на производство, 
    //регистрационен номер и двигател. Съшо трябва да има методите :
    //а) "Drive", на който му се подава скоростта като параметър.
    //б) "GetYears" - трябва да върне на колко години е колата - това става като от текущата година се извади
    //годината на производството на автомобила.
    //Създайте клас Кола, която да имплементира интерфейса.Допълнително да има свойство "Брой гуми" и метод "Старт Турбо".
    //Създайте клас Мотор, който да имплементира интерфейса. 
    class Program
    {
        static void Main(string[] args)
        {
            Car newCar = new Car("BMW", 2005, "PA7832BT", "1232N",4);
            newCar.Drive(232);
            Console.WriteLine("\nYOUR CAR'S INFO IS:");
            newCar.PrintCarInfo();
            Console.WriteLine();
            newCar.GetYears(2020);
            Console.WriteLine();
            newCar.StartTurbo();

            Motor newMotor = new Motor(2000);
            newMotor.GetYears(2005);
        }
    }
   

}
