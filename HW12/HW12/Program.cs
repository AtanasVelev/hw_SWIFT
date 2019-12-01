using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
//1.Направете собствено изключение(Exception) и го изполвайте в try-catch конструкция!

//2.Направете метод, който да приема две числа(number1 и number2) като параметри.
//Вътре в метода да има следната логика:
//Ако number1 е равен на number2 да се хвърли грешка, че числата не трябва да бъдат равни.
//Ако някое от числата е отрицателно да се хвърли друга грешка със съобщение, че числата не може да бъдат отрицателни.
//Ако не влизаме в горните две условия, тогава нека да се сметне сбора на числата и да се отпечати на конзолата.
//Извикайте този метод отнякъде в кода (примерно Main метода) и обработете възможните exception-и(s try-catch блока).
    class Program
    {
      
        static void Main()
        {
            NewExceptionExample testMethod = new NewExceptionExample();
            //testMethod.NewMethod(123, 45);
            //testMethod.NewMethod(45, 45);
            testMethod.NewMethod(-45, 45);

            //Console.WriteLine("Enter a 'string' with no more than 5 characters: ");
            //string name =Convert.ToString(Console.ReadLine());

            //try
            //{
            //    if (name.Length > 5)
            //    {
            //        throw new StrTooLongException("String is too long!");
            //    }
            //}
            //catch(StrTooLongException ex)
            //{
            //   Console.WriteLine(ex);
            //}

            //finally {
            //    Console.WriteLine("GOODBYE!");
            //}



        }
    }
}
