using System;
using System.Collections.Concurrent;

namespace ConsoleApplication2
{
    public class Task_1
    {
        
        
        
        
        
        /// <summary>
        /// Запуск задачи №1
        /// </summary>
        public void ShowDiagonleString()
        {
            Console.WriteLine("\nЗАДАЧА 1.Написать программу, выводящую элементы двумерного массива по диагонали.");
            LoadDataToArr();

        }

        /// <summary>
        /// Заоплняем массива от 0 до ...
        /// </summary>
        private void LoadDataToArr()
        {
            int[,] arr = CreatArray();
            int _arrSize = arr.GetLength(0) * arr.GetLength(0);
            int _step = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = _step < _arrSize ? ++_step : _step;
                }
            }

            WriteArray(arr, _arrSize);
        }

        
        /// <summary>
        /// Создаем массив
        /// </summary>
        /// <returns></returns>
        private int[,] CreatArray()
        {
            Console.Write("Введите размер двумерного массива: ");
            int _arrSize = Int32.Parse(Console.ReadLine());
            return new int[_arrSize,_arrSize];
        }

        private void WriteArray(int [,] _arr, int _arrSize)
        {
            Console.WriteLine("Результат:");
            int _step = 0;
            for (int i = 0; i < _arr.GetLength(0); i++)
            {
                for (int j = 0; j < _arr.GetLength(1); j++)
                {
                    ++_step;
                    var _ch = "";
                    if (_step == 0) Console.WriteLine(_arr[i, j]);
                    else
                    {
                        for (int k = 0; k < _step; k++)
                        {
                            _ch += " ";
                        }
                    }
                    Console.WriteLine($"{_ch}{_arr[i, j]}");
                }
            }
        }
    }
}