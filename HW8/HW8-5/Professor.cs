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
    class Professor:Lecturer
    {
        private string professorTitle;
        public string ProfessorTitle
        {
            get { return this.professorTitle; }
            set { this.professorTitle = value; }
        }
        public Professor()
        {

        }
        public void TitleAndWorkExperience(string professorTitle, int workExperience)
        {
            Console.WriteLine($"I am a {professorTitle} and my work experience is {workExperience} years!");
        }
        public override void  CheckHomework()
        {
            Console.WriteLine("I am your Professor and I will now check your HW!");
        }
        public void ConductAnExam()
        {
            Console.WriteLine("I am your Professor and I am conducting an exam!");
        }
    }
}
