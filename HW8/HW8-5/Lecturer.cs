using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_5
{
// Създайте клас Lecturer, който наследява Person и добавя наименование на университет, в който преподава.
//Класа Lecturer също трябва да има метод за проверка на домашни.  Класа Lecturer трябва да има 3 метода за провеждане на упражнения.
//Методите трябва да са с едно и също име на различен брой параметри.
//Класа Lecture трябва да има поне 2 конструктора (с и без параметри).Класа Lecturer трябва да има метод за поздрав само за добър ден.
//Нека всички Lecturers да имат поле, което не може да се изменя и което да съдържа информация за максимален брой лекции на седмица (примерно 10). 

    class Lecturer :Person
    {
        private string university;
        private const int NumberOfLectures = 10;
        
        public Lecturer()
        {
        }
        public Lecturer(string university)
        {
            this.university = university;
        }
 
        public string University
        {
            get { return this.university; }
            set { this.university = value; }
        }
        public void SayGoodDay()
        {
            Console.WriteLine("Good day!");
        }
        public virtual void CheckHomework()
        {
            Console.WriteLine(" I am your Lecturer and I will now check your HW!");
        }
        public void ConductExercise(string exerciseName)
        {
            Console.WriteLine($"I am conducting the following exercise: {exerciseName}");
        }
        public void ConductExercise(int exerciseNumber, string exerciseName)
        {
            Console.WriteLine($"Conduct exercise number: {exerciseNumber}, called {exerciseName}");
        }
        public void ConductExercise(int exerciseNumber, string exerciseName, int exerciseLength)
        {
            Console.WriteLine($"Conduct exercise: {exerciseName}, number: {exerciseNumber} that goes on for {exerciseLength} hours");
        }
    }
}
