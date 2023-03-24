using System.Collections;
using System.Runtime.ConstrainedExecution;
namespace Foobarssss
{
    public class Foobars
    {
        public static void foobarRun()
        {
            Console.WriteLine($"input the number : ");
            string? input = Console.ReadLine();
            int? inNum = Convert.ToInt32(input);
            int? index;

            Console.WriteLine(" ");
            Console.WriteLine("all number : ");
            for (index = 1; index <= inNum; index++)
            {
                Console.Write($"{index}, ");
            }

            Console.WriteLine(" ");
            Console.WriteLine("foobar : ");
            for (int i = 1; i <= index; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) Console.Write("foobar, ");
                else if (i % 3 == 0) Console.Write("foo, ");
                else Console.Write($"{i}, ");
            }
        }

        public static (String, String) foobarRun(int inNum)
        {
            string number = "";
            string numFoobar = "";
            int index;

            for (index = 0; index <= inNum; index++)
            {
                number = number + $"{index}, ";
            }

            for (int i = 0; i < index; i++)
            {
                if (i == 0) numFoobar = numFoobar + $"{i}, ";
                else if (i % 15 == 0) numFoobar = numFoobar + "foobar, ";
                else if (i % 3 == 0) numFoobar = numFoobar + "foo, ";
                else if (i % 5 == 0) numFoobar = numFoobar + "bar, ";
                else numFoobar = numFoobar + $"{i}, ";
            }
            return (number, numFoobar);
        }
    }
};
