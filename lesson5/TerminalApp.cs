using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    /// <summary>
    /// Класс для установления единых цветов, стиля оформления и при выводе
    /// </summary>
    abstract class TerminalApp
    {
        /// <summary>
        /// Цвет вывода сообщения об ошибке в консоли
        /// </summary>
        public ConsoleColor ErrorColor { get; set; }
        /// <summary>
        /// Цвет вывода заголовка в (тина названия задачи, шапки таблицы)
        /// </summary>
        public ConsoleColor HeaderColor { get; set; }
        /// <summary>
        /// Цвет вывода заголовка задачи
        /// </summary>
        public ConsoleColor TaskHeaderColor { get; set; }
        /// <summary>
        /// Последовательность символов, которую надо ввести с клавиатуры, чтобы закончить ввод списка строк
        /// </summary>
        public string TerminationString { get; set;  }

        private string _taskName;

        public TerminalApp(int taskNo) 
        { 
            ErrorColor = ConsoleColor.DarkRed;
            HeaderColor = ConsoleColor.Cyan;
            TaskHeaderColor = ConsoleColor.White;
            TerminationString = ":q";
            _taskName = $"Задание {taskNo}";
            DisplayTaskHeader();
        }

        /// <summary>
        /// Выводит заголовок правильным цветом
        /// </summary>
        /// <param name="header">Текст заголовка</param>
        public void DisplayHeader(string header) 
        { 
            Console.ForegroundColor = HeaderColor;
            Console.WriteLine(header);
            Console.ResetColor();
        }

        /// <summary>
        /// Выводит ошибку заданным цветом (ErrorColor)
        /// </summary>
        /// <param name="err">Текст ошибки</param>
        public void DisplayError(string err) 
        {
            Console.ForegroundColor = ErrorColor;
            Console.WriteLine(err);
            Console.ResetColor();
        }

        /// <summary>
        /// Отображает заголовок задачи
        /// </summary>
        protected void DisplayTaskHeader()
        {
            Console.ForegroundColor = TaskHeaderColor;
            Console.WriteLine($"=================== {_taskName} ===================");
            Console.ResetColor();
        }

        public abstract void Execute();
        

    }
}
