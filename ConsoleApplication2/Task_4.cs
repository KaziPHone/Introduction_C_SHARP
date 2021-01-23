using System;

namespace ConsoleApplication2
{
    public class Task_4
    {
        private string[,] _area = new string[10,10];
        
        /// <summary>
        /// Показываем выполнение задачи 4.
        /// </summary>
        public void ShowArea()
        {
            Console.WriteLine("\n«Морской бой»: вывести на экран массив 10х10, состоящий из символов X и O, где Х — " +
                              "элементы кораблей, а О — свободные клетки");
            SetElem();
            WriteArea();
        }

        /// <summary>
        /// Рисуем площадку с корабликами
        /// </summary>
        private void WriteArea()
        {
            string _areaTxt = "";
            for (int i = 0; i < _area.GetLength(0); i++)
            {
                for (int j = 0; j < _area.GetLength(1); j++)
                {
                    _areaTxt += _area[i, j] == null ? " O " : $" {_area[i, j]} ";
                }
                _areaTxt += "\n";
            }
            Console.WriteLine(_areaTxt);
        }

        /// <summary>
        /// Расставялем кораблики :)
        /// </summary>
        private void SetElem()
        {
            _area[1, 1] = "X";
            _area[1, 2] = "X";
            
            _area[5, 0] = "X";
            _area[6, 0] = "X";
            _area[6, 0] = "X";
            
            _area[9, 9] = "X";

            _area[5, 5] = "X";
            _area[5, 6] = "X";
            _area[5, 7] = "X";
        }
    }
}