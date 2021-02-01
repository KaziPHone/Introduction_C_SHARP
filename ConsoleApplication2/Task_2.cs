using System;
using System.IO;

namespace ConsoleApplication2
{
    public class Task_2
    {
        public void AddTimeToFile()
        {
            Console.WriteLine("ЗАДАЧА 2. Написать программу, которая при старте дописывает текущее время в файл «startup.txt»");
            const string FILE_NAME = "startup.txt";
            File.AppendAllText(FILE_NAME, $"\nТекущее время: {DateTime.Now.ToShortTimeString()}");
            Console.WriteLine($"Данные сохранены в {FILE_NAME}");
        }
    }
}