using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    internal class ConsoleDisplayer
    {
        private string _forma;
        private string _separator;

        public ConsoleDisplayer() {
            _forma = "{0,8}         {1,40}           {2,8}";
            _separator = "".PadLeft(85, '-');
        }
        //Вспомогательная функция. Просто выводит шапку
        private void DisplayHeader() 
        { 
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(_forma, "#", "Name", "Memory uses, M");
            Console.WriteLine(_separator);
            Console.ResetColor();
        }

        //Вспомогательная функция. Просто выводит подвал
        private void DisplayFooter(int Count, Int64 Mem) 
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(_separator);
            Console.WriteLine(_forma, "Total", Count, Mem);
            Console.ResetColor();
        }

        //Вспомогательная функция. Просто выводит список
        private void DisplayList(List<Process> list, out Int64 mem)
        {
            mem = 0;
            foreach (Process p in list)
            {
                Console.WriteLine(_forma, p.Id, p.ProcessName, p.VirtualMemorySize / (1024 * 1024));
                mem+=p.VirtualMemorySize;
            }
        }

        public void Display(List<Process> list) 
        {
            DisplayHeader();
            DisplayList(list, out Int64 mem);
            DisplayFooter(list.Count, mem/(1024*1024));
        }

        public void DisplayError(string message) 
        {
            Console.ForegroundColor= ConsoleColor.DarkRed;
            Console.WriteLine(message);
            Console.ResetColor();
        }

    }
}
