using System;
using System.IO;

namespace ConsoleApplication2
{
    public class Task_1
    {
        private string someText;

        public void WriteSomeText()
        {
            Console.WriteLine("ЗАДАЧА 1. Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.");
            Console.Write("Введите текст: ");
            someText = Console.ReadLine();
            const string FILE_NAME = "startup.txt";
            File.WriteAllText(FILE_NAME, someText);
            Console.WriteLine($"Данные сохранены в {FILE_NAME}");
        }
        
        
    }
}