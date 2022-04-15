using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    internal class DigitsWriter:FileWriter
    {
        /// <summary>
        /// Значение по умолчаню для нераспозданных чисел
        /// </summary>
        private byte _defaultValue;

        public DigitsWriter(int taskNo, string fileName, byte defaultValue=0) : base(taskNo, fileName)
        { 
            _defaultValue = defaultValue;
        }

        /// <summary>
        /// Получаем данные с клавиатуры от пользователя и преобразуем в массив byte[]
        /// </summary>
        /// <returns>массив байт</returns>
        override public byte[] GetUserData()
        {
            DisplayHeader($"Введите произвольное количество положительных цифр от нуля до 255, разделеных пробелами и нажмите <Enter>.");
            DisplayHeader($"Нераспознанные цифры будут заменены значением {_defaultValue}. Результат будет сохранен в файл \"{OutputFileName}\" ");         
            return TransferString(Console.ReadLine())??(new byte[1]);
        }

        /// <summary>
        /// Вспомогательная функция для перевода строки в byte с заменой на значение по умолчанию, если возникает ошибка
        /// </summary>
        /// <param name="str">Строка для перобразования</param>
        /// <param name="defaultValue">значение по умолчанию, если преобразование произошло с ошибкой</param>
        /// <returns></returns>
        private byte StrToByte(string str, byte defaultValue = 0)
        {
            byte result;
            if (!Byte.TryParse(str, out result))
            {
                result = defaultValue;
                DisplayError($"введенный набор символов <{str}> не является числом типа байт и будет представлен значением {defaultValue}");
            }
            return result;
        }

        /// <summary>
        /// Вспомогательная функия конвертации массива строк в массив byte
        /// </summary>
        /// <param name="inputStr"></param>
        /// <returns></returns>
        private byte[] TransferString(string inputStr) 
        {
            string[] sts = inputStr.Split(' ');
            byte[] result = new byte[sts.Length];
            for (int i=0;i<sts.Length; i++) { 
                result[i] = StrToByte(sts[i]);
            }
            return result;
        }


        public override void SaveUserData(object userData)
        {
            File.WriteAllBytes(OutputFileName, (byte[])userData);
        }

        /// <summary>
        /// Фанкция которая покажет в каком виде запиан результат в файл, а то так трудно прочитать 
        /// </summary>
        public void ShowDigitFile() 
        {
            if (!File.Exists(OutputFileName))
            {
                DisplayError($"Файл {OutputFileName} не существует ...");
            }
            else
            {
                Console.WriteLine($"Соержимое файла {OutputFileName} :");
                byte[] vs = File.ReadAllBytes(OutputFileName);
                foreach (byte b in vs)
                {
                    Console.WriteLine(b);
                }
            }
        }
    }
}
