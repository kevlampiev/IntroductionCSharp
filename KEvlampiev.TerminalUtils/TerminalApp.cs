using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEvlampiev.TerminalUtils
{
    public static class TerminalApp
    {
        /// <summary>
        /// Цвет вывода сообщения об ошибке в консоли
        /// </summary>
        public static ConsoleColor ErrorColor { get; set; }
        /// <summary>
        /// Цвет вывода заголовка в (тина названия задачи, шапки таблицы)
        /// </summary>
        public static ConsoleColor HeaderColor = ConsoleColor.Cyan;
        /// <summary>
        /// Цвет вывода заголовка задачи
        /// </summary>
        public static ConsoleColor TaskHeaderColor = ConsoleColor.White;
        /// <summary>
        /// Последовательность символов, которую надо ввести с клавиатуры, чтобы закончить ввод списка строк
        /// </summary>
        public static string TerminationString { get; set; }

        private static string _taskName;


        public static string TaskName { get { return _taskName; } set { _taskName = value; } }

        /// <summary>
        /// Выводит заголовок правильным цветом
        /// </summary>
        /// <param name="header">Текст заголовка</param>
        public static void DisplayHeader(string header)
        {
            Console.ForegroundColor = HeaderColor;
            Console.WriteLine(header);
            Console.ResetColor();
        }

        /// <summary>
        /// Выводит ошибку заданным цветом (ErrorColor)
        /// </summary>
        /// <param name="err">Текст ошибки</param>
        public static void DisplayError(string err)
        {
            Console.ForegroundColor = ErrorColor;
            Console.WriteLine(err);
            Console.ResetColor();
        }

        /// <summary>
        /// Отображает заголовок задачи
        /// </summary>
        public static void DisplayTaskHeader(string taskName, string userName)
        {
            Console.ForegroundColor= TaskHeaderColor;
            Console.WriteLine($"=================== {taskName} ===================");
            Console.WriteLine($"Выполнил: {userName}");
            Console.ResetColor();
        }


        public static int AskInteger(string prompt)
        {
            Console.Write(prompt + ": ");
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                return result;
            }
            else
            {
                DisplayError("Ошибка : введенный набор символов не является числом. Будет возвращено значение -1 .... ");
                return -1;
            }
        }

        public static string AskString(string prompt) 
        {
            Console.Write(prompt + ": ");
            return Console.ReadLine(); 
        }

        public static void WaitBeforeExit() 
        {
            Console.WriteLine("\n Для завершения нажмите любую клавишу");
            Console.ReadKey(true);
        }
    }

}