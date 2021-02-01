using System;
using System.IO;


namespace ConsoleApplication2
{
    public class Task_3
    {
        public void WriteByteFile()
        {
            Console.WriteLine("ЗАДАЧА 3. Введите произвольный набор чисел (0...255), разделенных пробелом: ");
            Console.Write("Введите цифры: ");
            var someText = Console.ReadLine().Split(' ');
            byte[] bytes = new byte[someText.Length];
            for (int i = 0; i < someText.Length; i++)  bytes[i] = (byte) Int32.Parse(someText[i]);
            const string FILE_NAME = "binar.bin";
            File.WriteAllBytes(FILE_NAME, bytes);
            //byte[] fromFile = File.ReadAllBytes(FILE_NAME);
            Console.WriteLine($"Данные сохранены в {FILE_NAME}");

        }
    }
}