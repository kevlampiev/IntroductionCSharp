using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process[] processes = Process.GetProcesses();
            int i=0;
            foreach (Process process in processes) {
                Int64 mem = process.VirtualMemorySize / (1024 * 1024);
                Console.WriteLine($"{i++,3}  {process.Id,12}  {process.ProcessName,40}  {mem.ToString("0,0"), 18}M");
            }
            Console.ReadKey();
        }
    }
}