using System;


namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Привет, как тебя зовут? ");
            var name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}, сегодня {DateTime.Now.ToShortDateString()}!");

            Console.ReadKey();
        }
    }
}