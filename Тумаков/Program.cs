using System;

namespace Тумаков
{
    class Program
    {
        static void Main(string[] args)
        {
            int Max(int num, int num2)
            {
                return (num > num2) ? num : num2;
            }

            void Swap(ref int num, ref int num2)
            {
                int copy = num;
                num = num2;
                num2 = copy;
                return;
            }

            int Factorial(int num)
            {
                int factorial = 1;
                try
                {
                    checked
                    {
                        for (int i = 1; i <= num; i++)
                        {
                            factorial *= i;
                        }
                        return factorial;
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Переполнение");
                    return 0;
                }
            }
           Console.WriteLine(Factorial(50000000));

            int Factorial2(int n)
            {
                if (n == 1)
                {
                    return 1;
                }

                return n * Factorial2(n - 1);
            }
            Console.WriteLine(Factorial(5));
        }
    }
}
