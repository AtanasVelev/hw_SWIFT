using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW14
{
//1. Напишете програма, която да превежда думите от английски на български.
//Направете си речник и задайте няколко думи да имат превод.
//След това въведете през конзолата някакво изречение и вижте с думите от Вашия речник колко от тях ще може да преведете.
//Примерно ако в моя речник имам превод на думите  "name", "eat", "sleep", "My", "bicycle".
//И имам дадено изречението "My name is Maria and I have bicycle" с моя речник ще мога да преведа изречението да изглежда така:
//"Моето име is Maria and I have колело".
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> newDictionary = new Dictionary<string, string>();

            newDictionary.Add("name","име");
            newDictionary.Add("eat", "ям");
            newDictionary.Add("sleep","спя");
            newDictionary.Add("My", "Моето");
            newDictionary.Add("bicycle", "колело");
          
            Console.WriteLine("Enter your sentence:");
            string userInput = Console.ReadLine();
            
                string[] sentence = userInput.Split(' ');
            foreach (string word in sentence)
            {
                if(newDictionary.ContainsKey(word))
                {
                    Console.Write($"{newDictionary[word]} ");
                }

                else
                {
                    Console.Write($"{word} ");
                }
                
            }
            Console.WriteLine();
                
            //newDictionary.ToList().ForEach(x => Console.WriteLine(x.Value + " " + x.Key));
        }
    }
}
