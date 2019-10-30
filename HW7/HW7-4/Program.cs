using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7_4
{
    //Задача 4: Дефинирайте клас, който съдържа информация за мобилен телефон: модел, производител, цена, собственик, характеристики на 
    //батерията и характеристики на екрана(големина и цветове).
    class MobilePhone
    {
        static void Main(string[] args)
        {
            MobilePhone newPhone = new MobilePhone("f32 ", "China ", 32, " Ivan ", "goodInfo ", 32, " infoisgood ");
            newPhone.Print();
        }
        private string model;
        private string maker;
        private int price;
        private string owner;
        private string batteryInfo;
        private int monitorSize;
        private string monitorInfo;



        public MobilePhone(string model, string maker, int price, string owner, string batteryInfo, int monitorSize, string monitorInfo)
        {
            this.model = model;
            this.maker = maker;
            this.price = price;
            this.owner = owner;
            this.batteryInfo = batteryInfo;
            this.monitorSize = monitorSize;
            this.monitorInfo = monitorInfo;
            
        }
        public void Print()
        {
            Console.WriteLine($"{model},{maker},{price},{owner},{batteryInfo},{monitorSize},{monitorInfo}");
        }
       
        
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public string Maker
        {
            get { return this.maker; }
            set { this.maker = value; }
        }
        public int Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public string Owner
        {
            get { return this.owner; }
            set { this.owner= value; }
        }
        public string BatteryInfo
        {
            get { return this.batteryInfo; }
            set { this.batteryInfo = value; }
        }
        public int MonitorSize
        {
            get { return this.monitorSize; }
            set { this.monitorSize = value; }
        }
        public string MonitorInfo
        {
            get { return this.monitorInfo; }
            set { this.monitorInfo = value; }
        }
        
    }
}
