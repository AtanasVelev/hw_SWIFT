using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_5
{
    // Създайте два класа Professor и Assistant, които да наследяват Lecturer.
    //Нека Professor да има допълнително поле за титла и метод, който да казва каква е титлата и колко години трудов стаж има.
    //Нека Assistant да има поле, което да пази информация, дали той е главен асистент или не е.
    //Нека Assistant да има и метод, който да казва как се казва и дали е главен асистент.
    //Нека класа Person да има брояч, който да знае колко обекта от неговите наследници са създадени.
    //Добавете проверка към цялата система, така че да не могат да се създават потребители с отрицателен брой години трудов стаж.

    class Assistant :Lecturer
    {
        private bool isChiefAssistant;
       
        public Assistant(bool isChiefAssitant)
        {
            this.isChiefAssistant = isChiefAssitant;
        }
        public void NameAndStatus(string firstName)
        {
            if (isChiefAssistant == true)
            {
                Console.WriteLine($"My name is {firstName} and I am the Chief Assistant");
            }
            else
            {
                Console.WriteLine($"My name is {firstName} and I am not the Chief Assistant");
            }

        }
        public bool IsChiefAssistant
        {
            get { return this.isChiefAssistant; }
            set { isChiefAssistant = value; }
        }
        public void IntroduceYourself()
        {
            Console.WriteLine("I am your Assistant!");
        }
        public override void CheckHomework()
        {
            Console.WriteLine("I am your Assistant and I will now check your HW!");
        }
        public void CheckAnExam()
        {
            Console.WriteLine("Now I am checking your exam!");
        }
        public void WriteScienceArticles()
        {
            Console.WriteLine("Now I am writing science articles.");
        }
        
    }
}
