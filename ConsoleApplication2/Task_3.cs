using System;


namespace ConsoleApplication2
{
    
    public class Task_3
    {
        private enum _monthYear
        {
            Winter = 1,
            Spring,
            Summer,
            Autumn
        };

        private void ReturnTimeYear(int quarter)
        {
            switch (quarter)
            {
                case (int)_monthYear.Winter:
                    Console.WriteLine("Зима");
                    break;
                case (int)_monthYear.Spring:
                    Console.WriteLine("Весна");
                    break;
                case (int)_monthYear.Summer:
                    Console.WriteLine("Лето");
                    break;
                case (int)_monthYear.Autumn:
                    Console.WriteLine("Осень");
                    break;
            }
        }

        private void DefinitionQuarter(int _num)
        {
            switch (_num)
            {
                case (int) 12:
                case (int) 1:
                case (int) 2:
                    ReturnTimeYear((int)_monthYear.Winter);
                    break;
                case (int) 3:
                case (int) 4:
                case (int) 5:
                    ReturnTimeYear((int)_monthYear.Spring);
                    break;
                case (int) 6:
                case (int) 7:
                case (int) 8:
                    ReturnTimeYear((int)_monthYear.Summer);
                    break;
                case (int) 9:
                case (int) 10:
                case (int) 11:
                    ReturnTimeYear((int)_monthYear.Autumn);
                    break;
            }
        }

        private void GetData()
        {
            int _num = 0;
            Console.Write("Введите число от 1 до 12 для определения времени года: ");
            try
            {
                _num = Int32.Parse(Console.ReadLine());
                if (_num < 1 || _num > 12)
                {
                    Console.WriteLine("Ошибка: введите число от 1 до 12");
                    GetData();
                }
                else
                {
                    DefinitionQuarter(_num);
                }
            }
            catch
            {
                Console.WriteLine("Ошибка: введите число от 1 до 12");
                GetData();
            }
        }
        
        public void StartTask()
        {
            Console.WriteLine("ЗАДАЧА 3. Написать метод по определению времени года. На вход подаётся число – " +
                              "порядковый номер месяца. На выходе — значение из перечисления (enum) — Winter, Spring, " +
                              "Summer, Autumn. Написать метод, принимающий на вход значение из этого перечисления и " +
                              "возвращающий название времени года (зима, весна, лето, осень). Используя эти методы, " +
                              "ввести с клавиатуры номер месяца и вывести название времени года. Если введено " +
                              "некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».");
            GetData();
        }


    }
}