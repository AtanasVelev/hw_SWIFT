using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    //Напишете клас, който да може да превръща долари в евро и обратното. Нека всеки път когато някой иска да превърне сума по-голяма от 10 000 (долара или евро)
    //да се „задейства“ събитие, което да информира всички, които са се абонирали за него. Може ли да направите различните самолети 
    //да задействат събитията при различни скорост и височина? Ако да – направете го
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter();
            Console.WriteLine(converter.ConvertToEuro(20));
            converter.ThresholdReached += () => Console.WriteLine("Over ten thousand!");
            Console.WriteLine(converter.ConvertToEuro(10001));
            Airplane newPlane = new Airplane();
            newPlane.HeightOverThreshold += () => Console.WriteLine($"Height over threshold: {newPlane.CurrentHeight}!");
            newPlane.SpeedOverThreshold += () => Console.WriteLine($"Speed over threshold: {newPlane.CurrentSpeed}!");
            newPlane.CurrentHeight = 12000;
            newPlane.CurrentSpeed = 600;

            FighterJet newJet = new FighterJet();
            newJet.SpeedOverThreshold += ()=> Console.WriteLine($"Speed over threshold: {newJet.CurrentSpeed}!");
            newJet.HeightOverThreshold += () => Console.WriteLine($"Height over threshold: {newJet.CurrentHeight}!");
            newJet.CurrentSpeed = 1000;
            newJet.CurrentHeight = 15000;

            PassengerPlane newPassengerPlane = new PassengerPlane();
            newPassengerPlane.SpeedOverThreshold += SpeedError;
            newPassengerPlane.CurrentSpeed = 2000;
            newPassengerPlane.HeightOverThreshold += HeightError;
            newPassengerPlane.CurrentHeight = 12000;
        }
        public static void HeightError()
        {
            Console.WriteLine("You are flying too high!");
        }
        public static void SpeedError()
        {
            Console.WriteLine("You are going too fast!");
        }
    } 
}
