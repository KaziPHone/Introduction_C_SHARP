using System;


namespace ConsoleApplication2
{
    
    public class Task_1
    {
        
        /// <summary>
        /// Пробуем через param
        /// </summary>
        /// <param name="values">ФИО</param>
        /// <returns></returns>
        public void GetFullName(params string[] values)
        {
            var result = "";
            foreach (var val in values)
            {
                result += $"{val} ";
            }
            Console.WriteLine(result);
        }

        /// <summary>
        /// Пробуем через передачу аргументов
        /// </summary>
        /// <param name="lastName">Фамилия</param>
        /// <param name="firstName">Имя</param>
        /// <param name="patronymic">Отчество</param>
        /// <returns></returns>
        public void GetFullName(string lastName, string firstName, string patronymic)
        {
            Console.WriteLine($"{lastName} {firstName} {patronymic}");
        }

        /// <summary>
        /// Пробуем модификатор out
        /// </summary>
        /// <param name="lastName">Фамилия</param>
        /// <param name="firstName">Имя</param>
        /// <param name="patronymic">Отчество</param>
        /// <param name="res"></param>
        public void GetFullName(string lastName, string firstName, string patronymic, out string res)
        {
            res = $"{lastName} {firstName} {patronymic}";
        }

        /// <summary>
        /// Пробуем модификатор ref
        /// </summary>
        /// <param name="lastName">Фамилия</param>
        /// <param name="firstName">Имя</param>
        /// <param name="patronymic">Отчество</param>
        public void GetFullName(ref string lastName, ref string firstName, ref string patronymic)
        {
            Console.Write("Введите фамилию: ");
            lastName = Console.ReadLine();
            Console.Write("Введите имя: ");
            firstName = Console.ReadLine();
            Console.Write("Введите отчество: ");
            patronymic = Console.ReadLine();
        }
    }
}