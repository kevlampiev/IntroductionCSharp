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
            ProcessHandler handler = new ProcessHandler();
            if (args.Length == 0)
            {
                handler.DisplayHelp();
                return;
            }
            
            string[] arguments = args[0].Split('=');
            switch (arguments[0]) {
                    case "list": handler.DisplayProcesses(); break;
                    case "help": handler.DisplayHelp(); break;
                    case "filter": handler.FilterStr = arguments[1]??"";
                                   handler.DisplayProcesses();
                                    break;
                    case "kill": handler.KillTheProccesses(arguments[1]);
                                    break;
                    default : handler.DisplayHelp(); break;

                }
            
            Console.ReadKey();
        }
    }
}