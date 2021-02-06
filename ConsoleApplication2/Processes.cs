using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.IO;



namespace ConsoleApplication2
{
    
    public class Processes
    {

        private Dictionary<string, string> _command = new Dictionary<string, string>()
        {
            ["help"] = "просмотр доступных команд",
            ["quit"] = "выход из приложения",
            ["clear"] = "очистить консоль",
            ["show-pr-c"] = "отобразить количество запущенных процессов",
            ["show-pr"] = "отобразить все запущенные процессы",
            ["show-dir"] = "отобразить текущую директорию",
            ["kill-id"] = "завершить процесс по его ID",
            ["kill-name"] = "завершить процесс по его имени"
        };

        private Process[] processes;
        private string workDir;
        
        
        public void TaskManagerRun()
        {
            Console.WriteLine("Добро пожаловать в Task Manager.\n" +
                              "Для просмотра доступных команд введите: help");
            GetCommand();
        }


        private void GetCommand()
        {
            Console.Write("\nВведите команду: ");
            var newCommand = Console.ReadLine();
            //Console.WriteLine($"команда {newCommand}");
            switch (newCommand)
            {
                case "help":
                    ShowCommand();
                    break;
                case "clear":
                    ClearConsole();
                    break;
                case "quit":
                    ConsoleQuit();
                    break;
                case "show-pr-c":
                    GetProcess();
                    break;
                case "show-dir":
                    ShowCurrentDir();
                    break;
                case "show-pr":
                    ShowProccess();
                    break;
                case "kill-id":
                    KillProcessId("");
                    break;
                case "kill-name":
                    KillProcessName();
                    break;
                default:
                    Console.WriteLine("Неизвестная команда. Попробуйте еще раз.");
                    GetCommand();
                    break;
            }
        }


        /// <summary>
        /// Отображаем текущую директорию
        /// </summary>
        private void ShowCurrentDir()
        {
            workDir = $@"{Directory.GetCurrentDirectory()}";
            Console.WriteLine($"Текущая директория: {workDir}");
        }


        /// <summary>
        /// Выход из приложение
        /// </summary>
        private void ConsoleQuit()
        {
            Console.WriteLine("Спасибо и до новых встреч!");
            Environment.Exit(0);
        }

        
        /// <summary>
        /// Очищаем консоль
        /// </summary>
        private void ClearConsole()
        {
            Console.Clear();
            Console.WriteLine("Task Manager");
            GetCommand();
        }
        
        
        /// <summary>
        /// Показываем доступные команды
        /// </summary>
        private void ShowCommand()
        {
            Console.WriteLine("Доступные команды:");
            foreach (var _item in _command)
            {
                Console.Write($"{_item.Key}:");
                Console.SetCursorPosition(15, Console.CursorTop);
                Console.Write($"{_item.Value}\n");
            }
            GetCommand();
        }

        
        /// <summary>
        /// Показываем количество запущенных процессов
        /// </summary>
        private void GetProcess()
        {
            if (processes == null) processes = Process.GetProcesses();
            Console.WriteLine($"Процессов запущено: {processes.Length}");
            GetCommand();
        }


        /// <summary>
        /// Показываем запущенные процесссы Id, name по 50 штук
        /// </summary>
        private void ShowProccess()
        {
            if (processes == null) processes = Process.GetProcesses();
            Console.Write("ID");
            Console.SetCursorPosition(10, Console.CursorTop);
            Console.Write("NAME");
            Console.WriteLine("");
            var i = 0;
            foreach (var proc in processes)
            {
                Console.Write($"{proc.Id}");
                Console.SetCursorPosition(10, Console.CursorTop);
                Console.Write($"{proc.ProcessName}");
                Console.Write("\n");
                NextProcess(ref i);

            }
            GetCommand();
        }

        
        /// <summary>
        /// Переход на след 50 процессов
        /// </summary>
        /// <param name="i"></param>
        private void NextProcess(ref int i)
        {
            i++;
            if (i >= 50)
            {
                i = 0;
                Console.WriteLine("Нажмите любую клавишу, чтобы продолжить");
                Console.ReadKey();
            }
        }

        
        /// <summary>
        /// Завершить процесс по Id
        /// </summary>
        /// <param name="procID"></param>
        private void KillProcessId(string procID)
        {
            int id = 0;

            if (processes == null) processes = Process.GetProcesses();
            if (procID == "")
            {
                Console.Write("Введите ID: ");
                procID = Console.ReadLine();
            }
            
            try
            {
                id = Convert.ToInt32(procID);
            }
            catch
            {
                Console.WriteLine("\nВы ввели некоректное значение");
            }
            
            try
            {
                foreach (var proc in processes)
                {
                    if (proc.Id == id)proc.Kill();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }
            GetCommand();
        }
        
        
        /// <summary>
        /// Завершить процесс по имени
        /// </summary>
        /// <param name="procID"></param>
        private void KillProcessName()
        {
            if (processes == null) processes = Process.GetProcesses();

            Console.Write("Введите имя процесса для его завершение: ");
            var procName = Console.ReadLine();
            
            try
            {
                foreach (var proc in processes)
                {
                    if (proc.ProcessName == procName)proc.Kill();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }
            GetCommand();
        }
        
    }
}