using System.Diagnostics;

namespace lesson6;

public class ProcessDisplayer
{
    //просто поле
    private Process[] _processes;

    /// <summary>
    /// Занятая память
    /// </summary>
    public Int64 TotalMemory {
        get
        {
            Int64 result = 0;
            foreach (Process process in _processes)
            {
                result += process.VirtualMemorySize64;
            }
            return result;
        }
    }
    /// <summary>
    /// Общее количество процессов
    /// </summary>
    public int TotalCount => _processes.Length;


    public ProcessDisplayer(Process[] processes)
    {
        _processes = processes;
    }

    private string FormatProcessString(Process process, int pointNo=1)
    {
        Int64 mem = process.VirtualMemorySize64 / (1024 * 1024);
        return $"{pointNo,3}  {process.Id,12}  {process.ProcessName,40}  {mem.ToString("0,0"), 18}M";
    }

    private void DisplayProcesses()
    {
        for (int i = 0; i < _processes.Length; i++)
        {
            Console.WriteLine(FormatProcessString(_processes[i], i));
        }
    }

    private void DisplayHeader()
    {
        Console.WriteLine("NN   Id          Name                                  Memory");
        Console.WriteLine("".PadLeft(60,'-'));
    }
    
    private void DisplayFooter()
    {
        Console.WriteLine("".PadLeft(60,'-'));
        Console.WriteLine($"Totally    {TotalCount} processes                        {TotalMemory/(1024*1024)} M");
    }

    public void Display()
    {
        DisplayHeader();
        DisplayProcesses();
        DisplayFooter();
    }

}