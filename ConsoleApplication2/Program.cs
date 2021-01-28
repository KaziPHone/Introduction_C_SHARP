using System;
using System.Threading;


namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Task_1 task1 = new Task_1();
            //аргументы
            task1.GetFullName("Иванов", "Юрий", "Юрьевич");
            //params
            task1.GetFullName(new[] {"Петров", "Юрий", "Юрьевич"});
            //out
            var result = "";
            task1.GetFullName("Сидоров", "Юрий", "Юрьевич", out result);
            Console.WriteLine(result);
            //ref
            var lastName = "Пупкин";
            var firstName = "Модест"; 
            var patronymic = "Петрович"; 
            task1.GetFullName(ref lastName, ref firstName, ref patronymic);
            Console.WriteLine($"{lastName} {firstName} {patronymic}");
            
            //=======================================
            
            Task_2 task2 = new Task_2();
            task2.Start();
            
            //=======================================
            
            Task_3 task3 = new Task_3();
            task3.StartTask();
            
            //=======================================
            Task_4 task4 = new Task_4();
            task4.Start();
            

            Console.ReadKey();
        }
    }
}