using System.Diagnostics;

namespace lesson6;

public class ProcessHandler
{
    /// <summary>
    /// Строка фильтра для фильтрации выводимых процессов
    /// </summary>
    public string FilterName { get; set;  }

    private Process[] _processes;

    private ProcessDisplayer _processDisplayer;

    public ProcessHandler(string filterName="")
    {
        FilterName = filterName;
        _processes = GetProcesses();
        _processDisplayer = new ProcessDisplayer(_processes);
    }

    private Process[] GetProcesses()
    {
        Process[] initial = Process.GetProcesses();
        if (FilterName == "") return initial;
        
        int newLength = 0;
        Process[] result = new Process[newLength];
        foreach (Process el in initial)
        {
            if (String.Compare(el.ProcessName.ToLower(), FilterName.ToLower()) == 0)
            {
                Array.Resize(ref result, ++newLength);
                result[newLength - 1] = el;
            }
        }
        return result;
    }

    public void DisplayProcessList()
    {
        
    }


}