using System;


namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Task_1 task1 = new Task_1();
            task1.ShowDiagonleString();
            
            Task_2 task2 = new Task_2();
            task2.ShowPhoneDir();
            
            Task_3 task3 = new Task_3();
            task3.ReturnStringHello();
            task3.WriteWordToConvers();
            
            Task_4 task4 = new Task_4();
            task4.ShowArea();
            Console.ReadKey();
            
            
        }
    }
}