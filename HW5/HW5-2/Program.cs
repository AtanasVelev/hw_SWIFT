using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.Имате даден този стринг : “Lorem ipsum dolor sit amet, consectetur adipiscing elit”; 
            //Сложете всяка дума да бъде отделен елемент на масив.

            string sentence = "Lorem ipsum dolor sit amet, consectetur adipiscing elit";
            
            string[] str = sentence.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            for(int i=0;i<str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
        }
    }
}
