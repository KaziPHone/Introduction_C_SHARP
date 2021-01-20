using System;

namespace Lesson_2_Task_4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\nЗадача 4.Для полного закрепления понимания простых типов найдите любой чек, либо фотографию этого чека в интернете и \n" +
                              "схематично нарисуйте его в консоли, только за место динамических, по вашему мнению, данных (это может быть дата, \n" +
                              "название магазина, сумма покупок) подставляйте переменные, которые были заранее заготовлены до вывода на консоль.");
            
            double _NDS = 0.2;
            
            Console.Write("Вы покупаете умную колонку 'Яндекс Станция с Алисой'. Введите сумму: ");
            double _sum = double.Parse(Console.ReadLine());
            Console.Write("Введите количество: ");
            int _count = int.Parse(Console.ReadLine());
            double _discount = 0.1;
            
            void WriteSymb(int n, string str)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("*");
                }
            }
            WriteSymb(30, "*");
            Console.WriteLine("\n");
            Console.WriteLine("OOO 'MBM'");
            Console.WriteLine("Москва, Ходынский б-р, 4");
            Console.WriteLine("А026");
            WriteSymb(30, "*");
            Console.WriteLine("\nТовар: 'Яндекс Станция с Алисой'");
            Console.WriteLine($"Цена за единицу: {_sum} руб.");
            Console.WriteLine($"Количество: {_count}");
            Console.WriteLine($"Скидка: {_discount * 100}%");
            Console.WriteLine($"НДС {((_sum * _count) * (1 - _discount)) * _NDS} руб. ");
            Console.WriteLine($"ИТОГО {(_sum * _count) - ((_sum * _count) * (1 - _discount)) * _NDS} руб. ");
            WriteSymb(30, "*");
            Console.WriteLine($"\nГарантия: 1 год");
            WriteSymb(30, "*");
            Console.WriteLine($"\nКассир: Пупкин Вася");
            Console.ReadKey();
        }
    }
}