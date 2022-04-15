using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    internal class StringsWriter : FileWriter
    {

       
        public StringsWriter(int taskNo, string fileName) : base(taskNo, fileName)
        { }
       
        /// <summary>
        /// Получаем данные с клавиатуры от пользователя
        /// </summary>
        /// <returns>коллекция строк с текстом пользователя</returns>
        public override List<string> GetUserData()
        {
            string userStr = "";
            List<string> userData = new List<string>();
            DisplayHeader($"Введите текст для сохранения. Для окончания ввода введите строку строку с комбинацией символов \"{TerminationString}\" ");
            while (userStr != TerminationString)
            {
                userStr = Console.ReadLine();
                if (userStr != TerminationString)
                {
                    userData.Add(userStr ?? "");
                }
            }
            return userData;
        }

        public override void SaveUserData(object userData)
        {

            File.WriteAllLines(OutputFileName, (List<string>)userData);
        }

    }
}
