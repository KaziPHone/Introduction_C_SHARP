using System;

namespace ConsoleApplication2
{
    public class Task_2
    {
        
        private string[,] _phoneDir = new string[5,2];
        
        /// <summary>
        /// Просмотр телефоннго справочника
        /// </summary>
        public void ShowPhoneDir()
        {
            
            Console.WriteLine("\nЗАДАЧА 2.Написать программу «Телефонный справочник»: создать двумерный массив 5х2, " +
                              "хранящий список телефонных контактов: первый элемент хранит имя контакта, второй — " +
                              "номер телефона/email.");
            InitilizeDir();
            Console.WriteLine(WriteDirTiScreen());
        }

        private void InitilizeDir()
        {
            for (int i = 0; i < _phoneDir.GetLength(0); i++)
            {
                _phoneDir[i, 0] = $"Фамилия_Имя_Отчество_{i + 1}";
                _phoneDir[i, 1] = $"Телефон/email_{i + 1}";
            }
        }

        private string WriteDirTiScreen()
        {
            var _txt = "";
            for (int i = 0; i < _phoneDir.GetLength(0); i++)
            {
                _txt += $"ФИО: {_phoneDir[i, 0]} Конт.данные: {_phoneDir[i, 1]}\n";
            }
            return _txt;
        }
    }
}