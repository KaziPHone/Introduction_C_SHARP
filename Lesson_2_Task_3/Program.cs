using System;

namespace Lesson_2_Task_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\nЗадача 3. Определить, является ли введённое пользователем число чётным.");
            Console.Write("Введите число: ");
            var num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0) Console.WriteLine($"Число {num} - четное!");
            else Console.WriteLine($"Число {num} - нечетное!");

            Console.ReadKey();
        }
    }
}