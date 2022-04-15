using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    abstract class FileWriter : TerminalApp
    {
        /// <summary>
        /// Имя файла, куда будут записываться данные, которые навводил пользователь
        /// </summary>
        public string OutputFileName { get; set; }

        public FileWriter(int taskNo, string fileName):base(taskNo)
        {
            OutputFileName = fileName;
        }

        /// <summary>
        /// Получаем данные с клавиатуры от пользователя
        /// </summary>
        /// <returns>коллекция строк с текстом пользователя</returns>
        abstract public object GetUserData();

        abstract public void SaveUserData(object userData);

        public override void Execute() 
        {
            try
            {
                object userData = GetUserData();
                SaveUserData(userData);
                DisplayHeader($"Данные сохранены в файл {OutputFileName}...");
            }
            catch (Exception ex) {
                DisplayError(ex.Message);
            }
        }

    }
}
