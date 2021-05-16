using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Pass a 32-bit number to calculate and return the Factorial
            /// </summary>
            /// <param name="number"></param>
            /// <returns>32-bit integer</returns>
            static int Factorial(int number)
            {
                if (number < 1)
                {
                    return 0;
                }
                else if (number == 1)
                {
                    return 1;
                }
                else
                {
                    checked // check type overflow
                    {
                        return number * Factorial(number - 1);
                    }
                }
            }

            static void RunFactorial()
            {
                for (var i = 1; i < 15; i++)
                {
                    try
                    {
                        System.Console.WriteLine($"{i}! = {Factorial(i):N0}");
                    }
                    catch (OverflowException)
                    {
                        System.Console.WriteLine($"{i}! is too big for a 32-bit integer.");
                    }

                }
            }

            RunFactorial();
        }
    }
}
