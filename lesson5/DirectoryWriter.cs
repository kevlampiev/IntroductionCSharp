using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace lesson5
{
    internal class DirectoryWriter:FileWriter
    {
        public bool UseRecursion { get; set; }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="taskNo">Номер задачи урока</param>
        /// <param name="fileName">Имя файла для вывода информации</param>
        /// <param name="useRecursion">Использовать рекурсивную функцию или (по умолчанию) стандартную </param>
        public DirectoryWriter(int taskNo, string fileName, bool useRecursion=false):base(taskNo, fileName)
        {
            UseRecursion = useRecursion;
        }

        /// <summary>
        /// Запрашивает механически корректный путь для отображения содержимого (не останет, пока не получит правильный путь) 
        /// </summary>
        /// <returns>корректное название директории</returns>
        public override object GetUserData()
        {
            string pathName;
            while(true) {
                DisplayHeader("Введите полный путь директории, котрую хотите просканировать. Нажмите <Enter> для выбора текущей директории.");
                pathName = Console.ReadLine();
                if (pathName == null||pathName=="") {
                    return (object) Directory.GetCurrentDirectory();
                } else if (!Directory.Exists(pathName))
                {
                    DisplayError("Введенная директория не существует");
                } else {
                    return (object) pathName;
                }
            }
        }

        public override void SaveUserData(object userData)
        {
            File.WriteAllText(OutputFileName, userData.ToString()+"  "+UseRecursion.ToString()+"\n");
            List<string> fileList = UseRecursion?BuildFileListR(userData.ToString()):BuildFileListNR(userData.ToString());
            foreach (string path in fileList) {
                File.AppendAllText(OutputFileName, formatFileString(path)+"\n");
            }
        }

        // Вспомогательная функция. Строит рекурсивно не очень пригодный для отображения перечень файлов и директорий
        private List<string> BuildFileListR(string dirName, List<string> fileList = null)
        {
            fileList = fileList ?? new List<string>();
            try
            {
                string[] entries = Directory.GetFileSystemEntries(dirName);
                foreach (string entry in entries)
                {
                    fileList.Add(entry);
                    if (Directory.Exists(entry))
                    {
                        try { 
                            BuildFileListR(entry, fileList); 
                        } catch(Exception ex) {
                            DisplayError(ex.Message);
                        }
                    }
                }
            }
            catch (UnauthorizedAccessException ex) {
                DisplayError(ex.Message);
            }
            return fileList;
        }


        //вспомогательная функция. Строит без рекурский не очень пригодный для просмотра перечень файлов
        private List<string> BuildFileListNR(string dirName)
        {
            List<string> result = new List<string>();
            string[] entries = Directory.GetFileSystemEntries(dirName,"*",SearchOption.AllDirectories);
            foreach (string entry in entries) 
            {
                result.Add(entry);    
            }
            result.Sort();
            return result;
        }


        //Вспомогательная функция подсчета количества символов разделителя директорий в строке пути. Поскольку не силен в C# и не нашел более станартного
        private int dirLevel(string str)
        {
            string searchStr = Path.DirectorySeparatorChar.ToString();
            return (str.Length - str.Replace(searchStr, "").Length);
        }

        //Причесывает строку с файлом или директорией для понятного отображения
        private string formatFileString(string fileString, char indent = '-')
        {
            int depth = dirLevel(fileString);
            string directoryMark = Directory.Exists(fileString) ? "<DIR>" : "     ";
            return directoryMark + "".PadLeft(depth, indent) + Path.GetFileName(fileString);
        }


    }
}
