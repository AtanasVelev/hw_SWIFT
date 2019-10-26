using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1: Напишете метод, който да приема като параметри име и възраст на човек и да ги отпечати на козолата
            //Извикайте дадения метод няколко пъти с различни данни.

            GetNameAndAgeOfUser("Ivan",32);
            GetNameAndAgeOfUser("Pesho", 35);
            GetNameAndAgeOfUser("Mariika", 43);
            GetNameAndAgeOfUser("Lybo", 21);
        }

        public static void GetNameAndAgeOfUser(string name, int age)
        {
            Console.WriteLine($"Hello,{name}! Your age is {age}");
        }
    }
}
