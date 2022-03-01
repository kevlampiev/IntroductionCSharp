using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! \n Pls, introduce yourself :");
            string userName = Console.ReadLine();

            Console.WriteLine($"Hello again, {userName}! Today is {DateTime.Now}\n Press any key to continue .... ");
            Console.ReadKey();
        }
    }
}
