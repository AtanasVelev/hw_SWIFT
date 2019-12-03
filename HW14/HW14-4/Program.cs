using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW14_4
{
    class Program
    {
//4. Нека имаме дадения стринг:
//"My name {Ivan} and my dog {Sharo}”
//Направете програмa, която да проверява дали броя на съдържащите се отварящи скоби е равен на броя на затварящите се в дадения стринг.
//        След това обхождате всеки елемент на масива и проверявате дали съдържа отваряща скоба - ако да, пъхате в стека, ако съдържа затваряща - махате от стека.
//        Ако се опитате да махнете от скета, елемент докато там няма накакъв, ще получите exception.
//        Накрая, ако скобите са равен брой , Count-a на стека трябва да е 0.

//След като я направите програмата, проверете дали работи добре като промените изречението с някакво друго, примерно с НЕ равен брой отварящи и затварящи скоби.




        static void Main(string[] args)
        {
            string text = "My name {{{{{Ivan} and my dog {Sharo}";
            Stack<char> charStack = new Stack<char>();

            char[] letters = text.ToCharArray();
            foreach(char symbol in letters)
            {
                if (symbol == '{')
                {
                    charStack.Push(symbol);
                }
                if (symbol == '}')
                {
                    charStack.Pop();
                }
            }
            Console.WriteLine(charStack.Count);
        }
    }
}
