using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Задача 4: Създайте структура Flower, в която да имате свойствата Name, Color, Height и метод "Цъфти".
namespace HW7_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Flower Flower1 = new Flower("Rose", "Red", 12);
            Flower1.Blossom();
        }
    }
    struct Flower
    {
        private string name;
        private string colour;
        private int height;
        
        public  Flower(string name, string colour, int height)
        {
            this.name = name;
            this.colour = colour;
            this.height = height;
        }
        public void Blossom()
        {
            Console.WriteLine($"{name},{colour},{height}");
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Colour
        {
            get { return this.colour; }
            set { this.colour = value; }
        }
        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }
    }
    
}
