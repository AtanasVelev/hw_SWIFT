using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW14_2
{
    //2. Напишете програма, която приема 20 думи и показва по колко пъти се среща всяка една от тях.
    class Program
    {
        static void Main(string[] args)
        {
            string randomWords;
            randomWords = "apple banana apple orange pineapple blueberry raspberry lemon watermelon banana pineapple " +
                "strawberry blueberry orange mango kiwi melon raspberry apple orange";

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            string[] words = randomWords.Split(' ');

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
                Console.WriteLine($"{pair.Key} - > {pair.Value}");
            }

        }

    }
}
