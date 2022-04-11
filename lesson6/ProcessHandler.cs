using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    internal class ProcessHandler
    {
        //Список всех процессов
        private Process[] _processes;
        private string _filterString;

        //Кто будет выводить данные на консоль
        ConsoleDisplayer _displayer;

        /// <summary>
        /// Строка для фильтра процессво по наименованию
        /// </summary>
        public string FilterStr { get { return _filterString; } set { SetFilterStr(value); } }

        /// <summary>
        /// Список отфильтрованных процессов
        /// </summary>
        public List<Process> ProcessesToDisplay { get { return GetProcesses(); }}
        /// <summary>
        /// Общее количество отфильтрованных процессов
        /// </summary>
        public int ProcessCount { get; set; }
        public Int64 OccupiedMemory { get;  }

        public ProcessHandler() 
        {
            _processes = Process.GetProcesses();
            _filterString = "";
            _displayer = new ConsoleDisplayer();
        }

        private List<Process> GetProcesses()
        {
            if (_filterString == "")
            {
                return _processes.ToList();
            }
            else 
            {
                List<Process> result = new List<Process>();
                foreach (Process process in _processes) {
                    if (process.ProcessName.ToLower().Contains(_filterString.ToLower()))
                        { 
                        result.Add(process);
                    }
                }
                return result;
            }
        }

        private void SetFilterStr(string filter) 
        {
            _filterString = filter??"";
            if (filter != "") 
            { 
                Console.WriteLine($"При  выводе списка процессов используется фильтр '{filter}'");
            }
        }

        private bool IsSuitable(Process proccess, string victimMask) 
        {
            if (victimMask == "") return false;

            bool result = proccess.ProcessName.ToLower().Contains(victimMask.ToLower());
            return result || (proccess.Id.ToString() == victimMask);
        }

        public void KillTheProccesses(string victimMask) 
        {
            victimMask = victimMask ?? "";
            foreach (Process process in _processes) 
            {
                if (IsSuitable(process, victimMask)) {
                    try {
                        process.Kill();
                        Console.WriteLine($"Процесс {process.Id}  {process.ProcessName} завершен...");
                    } catch (Exception ex) { 
                        _displayer.DisplayError(ex.Message);
                    }
                }
            }
        }


        /// <summary>
        /// Выводит список процессов с учетом фильтра
        /// </summary>
        public void DisplayProcesses()
        { 
            _displayer.Display(GetProcesses());
        }

        /// <summary>
        /// Выводит справочную информацию
        /// </summary>
        public void DisplayHelp() {
            string helpStr = @"Использование: 
list - вывести список всех процессов
filter=<подстрока поиска> - вывести процессы, название которых содержит строку поиска
kill=<id или фрагмент имени процесса> - убить процесс с номером id или имя каторого содержит заданный фрагмент
help или отсутствие аргумента - вывести этот текст";
            Console.WriteLine(helpStr);
        }
        
    }
}
