using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    //Вътре в метода да има следната логика:
    //Ако number1 е равен на number2 да се хвърли грешка, че числата не трябва да бъдат равни.
    //Ако някое от числата е отрицателно да се хвърли друга грешка със съобщение, че числата не може да бъдат отрицателни.
    //Ако не влизаме в горните две условия, тогава нека да се сметне сбора на числата и да се отпечати на конзолата.
    //Извикайте този метод отнякъде в кода (примерно Main метода) и обработете възможните exception-и(s try-catch блока).
    public class NewExceptionExample
    {
        public void NewMethod(int num1, int num2)
        {
            try
            {
                if (num1 == num2)
                {
                    throw new InvalidOperationException("Numbers shouldn't be equal!");
                }
            }
            catch (InvalidOperationException ex1)
            {
                Console.WriteLine(ex1);
            }
            try
            {
                if (num1 < 0 || num2 < 0)
                {
                    throw new ArgumentOutOfRangeException(" You must enter a positive integer number!");
                }
            }
            catch (ArgumentOutOfRangeException ex2)
            {
                Console.WriteLine(ex2);
            }
            finally
            {
                int result = num1 + num2;
                Console.WriteLine($" {num1} + {num2} = {result}");
            }

        }
    }
}
