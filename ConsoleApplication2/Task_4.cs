using System;
using System.IO;
using System.Linq;


namespace ConsoleApplication2
{
    public class Task_4
    {
        private string workDir = $@"{Directory.GetCurrentDirectory()}";
        
        
        /// <summary>
        /// Создаем каталоги/подкаталоги и файлы в них
        /// </summary>
        private void CreatDirectories()
        {
            var parentPath = "Parent_Folder";
            Directory.CreateDirectory(parentPath);
            var childFolder = "Child_Folder";
            for (int i = 0; i < 5; i++)
            {
                var childPath = $"Parent_Folder\\Child_Folder_{i}";
                Directory.CreateDirectory(childPath);
                CreatFileInChildDir(childPath);
            }
        }

        /// <summary>
        /// Создаем файлы в каталоге
        /// </summary>
        /// <param name="path">Путь для подкаталога</param>
        private void CreatFileInChildDir(string path)
        {
            Random rnd = new Random();
            int maxCountNewFile = rnd.Next(1, 10);
            
            for (int i = 0; i < maxCountNewFile; i++) //заполняем файлами каталог рандомным количеством 
            {
                File.AppendAllText($"{path}\\file_{i}.txt", $"Какой-то текст для файла file_{i}.txt " +
                                                            $"в директории: {workDir}\\{path}");
            }
            
            if (maxCountNewFile < 5) CreatFileInChildToChildDir($"{path}\\Child_To_Child_Folder_{maxCountNewFile}");
        }
        
        /// <summary>
        /// рандомом решаем создавать ли подкаталог в каталоге
        /// </summary>
        /// <param name="path"></param>
        private void CreatFileInChildToChildDir(string path)
        {
            Random rnd = new Random();
            var maxCountNewFile = rnd.Next(1, 10);
            Directory.CreateDirectory(path);
            for (var i = 0; i < maxCountNewFile; i++)
            {
                File.AppendAllText($"{path}\\random_file_{i}.txt", $"Какой-то текст для файла file_{i}.txt в директории: {workDir}\\{path}");
            }
        }

        /// <summary>
        /// Возвращаем на экран созданные каталоги с файлами
        /// </summary>
        /// <param name="path"></param>
        private void WriteDir(string path)
        {
            int indexOfChar = 0;
            var dir = Directory.GetDirectories(path);
            foreach (var folder in dir)
            {
                var arrDir = folder.Split('\\');
                Console.WriteLine($"{arrDir.Last()}:");
                WriteChildDir(folder, 0);
            }
        }


        private void WriteChildDir(string path, int left)
        {
            Console.SetCursorPosition(left + 2, Console.CursorTop);
            int indexOfChar = 0;
            var files = Directory.GetFiles(path);
            foreach (var file in files)
            {
                var arrDir = file.Split('\\');
                Console.SetCursorPosition(left + 2, Console.CursorTop);
                Console.WriteLine($"{arrDir.Last()}");
            }
            var dir = Directory.GetDirectories(path);
            if (dir.Length > 0)
            {
                foreach (var folder in dir)
                {
                    var arrDir = folder.Split('\\');
                    Console.SetCursorPosition(left + 2, Console.CursorTop);
                    Console.WriteLine($"{arrDir.Last()}:");
                    WriteChildDir(folder, left + 4);
                }
            }
        }
        
        
        public void StartTask()
        {
            Console.WriteLine("ЗАДАЧА 4. Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — " +
                              "с рекурсией и без.");
            CreatDirectories();
            WriteDir($"{workDir}\\Parent_Folder"); //выводим все в консоль
        }
    }
}