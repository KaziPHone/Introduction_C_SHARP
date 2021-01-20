using System;

namespace Lesson_2_Task_2
{
    internal class Program
    {
        enum _monthYear
        {
            January = 1, February, March, April,
            May, June, July, August, September,
            October, November, December
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine("\nЗадача 2. Запросить у пользователя порядковый номер текущего месяца и вывести его название.");
            Console.Write("Введите номер текущего месяца: ");
            var _month = Convert.ToInt32(Console.ReadLine());
            switch (_month)
            {
                case (int)_monthYear.January:
                    Console.WriteLine("Сейчас Январь");
                    break;
                case (int)_monthYear.February:
                    Console.WriteLine("Сейчас Февраль");
                    break;
                case (int)_monthYear.March:
                    Console.WriteLine("Сейчас Март");
                    break;
                case (int)_monthYear.April:
                    Console.WriteLine("Сейчас Апрель");
                    break;
                case (int)_monthYear.May:
                    Console.WriteLine("Сейчас Май");
                    break;
                case (int)_monthYear.June:
                    Console.WriteLine("Сейчас Июнь");
                    break;
                case (int)_monthYear.July:
                    Console.WriteLine("Сейчас Июль");
                    break;
                case (int)_monthYear.August:
                    Console.WriteLine("Сейчас Август");
                    break;
                case (int)_monthYear.September:
                    Console.WriteLine("Сейчас Сентярь");
                    break;
                case (int)_monthYear.October:
                    Console.WriteLine("Сейчас Октябрь");
                    break;
                case (int)_monthYear.November:
                    Console.WriteLine("Сейчас Ноябрь");
                    break;
                case (int)_monthYear.December:
                    Console.WriteLine("Сейчас Декабрь");
                    break;
                default:
                    Console.WriteLine("Не понятное значение");
                    break;
            }

            Console.ReadKey();
        }
    }
}