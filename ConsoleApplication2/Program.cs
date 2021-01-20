using System;

namespace ConsoleApplication2
{
    
    internal class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Задача 1. Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.");
            Console.Write("Введите минимальную температуру за сутки: ");
            var _t1 = double.Parse(Console.ReadLine());
            Console.Write("Введите максимальную температуру за сутки: ");
            var _t2 = double.Parse(Console.ReadLine());
            var _tAvg = (_t1 + (_t2)) / 2;
            Console.WriteLine($"Среднесуточная температура: {_tAvg}");
            if (_tAvg < 0) Console.WriteLine($"Возможно наступила зима?");

        }
    }
}