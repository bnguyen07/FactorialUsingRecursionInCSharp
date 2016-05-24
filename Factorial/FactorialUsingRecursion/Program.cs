using System;
using System.Numerics;

namespace FactorialUsingRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            //max value of int : 2,147,483,647
            Console.WriteLine("Please enter a number less than 17 to find factorial: ");
            var input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(input + "! = " + FactorialUsingRecursion(input));

            Console.WriteLine("Please enter a number less than 17 to find factorial: ");
            var inputForOneLine = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(inputForOneLine + "! = " + OneLineFactorialUsingRecursion(inputForOneLine));

            //max value of long : 9,223,372,036,854,775,807
            Console.WriteLine("Please enter a number less than 24 to find factorial: ");
            var bigInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(bigInput + "! = " + BigFactorialUsingRecursion(bigInput));

            //now the max value depends on your machine's memory
            Console.WriteLine("Please enter a number less than 8000 to find factorial: ");
            var superBigInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(superBigInput + "! = " + SuperBigFactorialUsingRecursion(superBigInput));
            
            Console.ReadLine();
        }

        static int FactorialUsingRecursion(int n)
        {
            if (n < 0)
            {
                return -1;
            }
            if (n == 0)
            {
                return 1;
            }
            return n*FactorialUsingRecursion(n - 1);
        }

        static long BigFactorialUsingRecursion(int n)
        {
            if (n < 0)
            {
                return -1;
            }
            if (n == 0)
            {
                return 1;
            }
            return n*BigFactorialUsingRecursion(n - 1);
        }

        static BigInteger SuperBigFactorialUsingRecursion(int n)
        {
            if (n < 0)
            {
                return -1;
            }
            if (n == 0)
            {
                return 1;
            }
            return n * SuperBigFactorialUsingRecursion(n - 1);
        }

        static int OneLineFactorialUsingRecursion(int n)
        {
            return n < 0 ? -1 : (n == 0 ? 1 : n*OneLineFactorialUsingRecursion(n - 1));
        }
    }
}
