using System;


namespace ConsoleApplication2
{
    
    public class Task_2
    {
        private void WriteResult(string str)
        {
            var result = 0;
            string[] arr = str.Split(' ');
            foreach (var n in arr)
            {
                result += Int32.Parse(n);
            }
            Console.WriteLine($"Результат: {result}");
        }

        public void Start()
        {
            Console.Write("ЗАДАЧА 2. Написать программу, принимающую на вход строку — набор чисел, " +
                              "разделенных пробелом, и возвращающую число — сумму всех чисел в строке. " +
                              "Ввести данные с клавиатуры и вывести результат на экран\nВведите данные: ");
            
            WriteResult(Console.ReadLine());
        }
    }
}