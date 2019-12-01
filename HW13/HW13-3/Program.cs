using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13_3
{
    class Program
    {
      //3. Напишете си клас Bike и му задайте да има следните свойства: Brand, Model и Color.
      //Създайте някоклко инстанции пак от класа Bike и ги добавете в свързания списък LinkedList.
      //Обходете го и принтирайте подробна информация за колите.
        static void Main(string[] args)
        {
            Bike newBike1 = new Bike("BMX", "A15", "Blue");
            Bike newBike2 = new Bike("SPRINT", "R3", "Green");
            Bike newBike3 = new Bike("RUNNER", "DAS2112", "Red");
            Bike newBike4 = new Bike("LIGHTNING", "XXW2", "Grey");
            Bike newBike5 = new Bike("THUNDER", "12323D", "Yellow");
            Bike newBike6 = new Bike("BiG_Bike", "2003", "Black");
            Bike newBike7 = new Bike("Small_Bike", "2013", "Orange");
            Bike newBike8 = new Bike("Middle_Bike", "2020", "White");
            Bike newBike9 = new Bike("PUMA_Bike", "2888", "Purple");
            Bike newBike10 = new Bike("TIGER_Bike", "007", "Brown");

            LinkedList<Bike> bikeList = new LinkedList<Bike>();
            bikeList.AddFirst(newBike1);
            bikeList.AddAfter(bikeList.First, newBike2);
            bikeList.AddAfter(bikeList.First.Next, newBike3);
            bikeList.AddAfter(bikeList.First.Next.Next, newBike4);
            bikeList.AddAfter(bikeList.First.Next.Next.Next, newBike5);
            bikeList.AddLast(newBike7);
            bikeList.AddBefore(bikeList.Last, newBike10);
            bikeList.AddBefore(bikeList.Last.Previous, newBike6);
            bikeList.AddFirst(newBike8);
            bikeList.AddLast(newBike9);

            Console.WriteLine("BIKES INFO");
            foreach (Bike bike in bikeList)
            {
                Console.WriteLine($"Brand:{bike.Brand} Model:{bike.Model} Color:{bike.Color}");
            }
        }
    }
}
