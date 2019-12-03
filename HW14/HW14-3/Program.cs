using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW14_3
{
    //3. Напишете програма, която приема текст и извежда на екрана всички думи, които са уникални (срещат се само веднъж).

    class Program
    {
        static void Main(string[] args)
        {
            string text;
            text = "I have a dog. It is very good dog. I love my dog so much. The dog is a great dog.";

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            string[] words = text.Split(' ');

            foreach (string word in words)
            {
                int count = 1;
                if (wordsCount.ContainsKey(word))
                {
                    count = wordsCount[word] + 1;
                    
                }
                wordsCount[word] = count;

            }
            foreach (var pair in wordsCount)
            {
                if (pair.Value == 1)
                {
                    Console.WriteLine($"{pair.Key} - > {pair.Value}");
                }
                else continue;
            }

        }
    
    }
}
