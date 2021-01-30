using System;

namespace ConsoleApplication2
{

    public class Task_4
    {
        private int n = 0;
        private int num1 = 0;
        private int num2 = 0;
        
        public void Start()
        {
            Console.WriteLine("Написать программу, вычисляющую число Фибоначчи для заданного значения " +
                              "рекурсивным способом.");
            Console.Write("Введите число: ");
            n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("");
            Fib(0);
        }

        
        
        private void Fib(int i)
        {
            if (i == 0)
            {
                i++;
                num2 += i;
                Console.Write($"{num1} {num2} ");
                Fib(i);
            }
            else if (i < n)
            {
                i++;
                Console.Write($"{(num1) + (num2)} ");
                var b = num1;
                num1 = num2;
                num2 = b + num1;
                Fib(i);
            }
        }
    }
}