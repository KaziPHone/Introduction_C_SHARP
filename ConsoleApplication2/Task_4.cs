using System;

namespace ConsoleApplication2
{

    public class Task_4
    {
        private int n = 0;
        private int j = 2;
        private int i = 0;
        
        public void Start()
        {
            Console.WriteLine("Написать программу, вычисляющую число Фибоначчи для заданного значения " +
                              "рекурсивным способом.");
            Console.Write("Введите число: ");
            n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("");
            Fibonacci(i);
        }

        private void Fibonacci(int t)
        {
            if (t <= 1)
            {
                Console.Write($"{t} ");
            }
            else
            {
                j = (i - 1) + (i - 2);
                Console.Write($"{j} ");
                i++;
                if (i < n)
                {
                    Fibonacci(i);
                }
            }
        }
    }
}