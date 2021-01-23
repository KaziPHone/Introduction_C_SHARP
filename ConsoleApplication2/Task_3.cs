using System;

namespace ConsoleApplication2
{
    public class Task_3
    {
        
        private const string _HELLO = "Hello";

        /// <summary>
        /// Вывод на экран "Hello" в обратном порядке
        /// </summary>
        public void ReturnStringHello()
        {
            Console.WriteLine("\nЗАДАЧА 3. Написать программу, выводящую введённую пользователем строку в обратном порядке " +
                              "(olleH вместо Hello)");
            Console.WriteLine($"Ответ: {ConversString(_HELLO)}");
        }
        
        /// <summary>
        /// Вы можете проверить алгоритм отображения слова в обратном порядке
        /// </summary>
        public void WriteWordToConvers()
        {
            Console.WriteLine("\nВведите слово для проверки: ");
            var _txt = Console.ReadLine();
            if (_txt != "") Console.WriteLine($"Ответ: {ConversString(_txt)}");
            else Console.WriteLine("Вы ничего не ввели :(!");
        }
        
        private string ConversString(string _setTxt)
        {
            var _txt = "";
            for (int i = _setTxt.Length - 1; i >= 0; i--)
            {
                _txt += _setTxt[i];
            }
            return _txt;
        }
        
    }
}