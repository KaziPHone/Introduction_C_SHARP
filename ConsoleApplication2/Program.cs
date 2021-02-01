using System;
using System.Text.Json;


namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Task_1 task1 = new Task_1();
            task1.WriteSomeText();
            
            Task_2 task2 = new Task_2();
            task2.AddTimeToFile();
            
            Task_3 task3 = new Task_3();
            task3.WriteByteFile();
            
            Task_4 task4 = new Task_4();
            task4.StartTask();
            
            
            Console.ReadKey();
        }
    }
}