using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    internal class Program
    {
              
        static void Main(string[] args)
        {
            //Задача 1
            (new StringsWriter(1, "task5.1.txt")).Execute();
            //Задача 2
            (new TimeWriter(2, "task5.2.txt")).Execute();
            //Задача 3
            DigitsWriter dr = new DigitsWriter(3, "task5.3.dat");
            dr.Execute();
            dr.ShowDigitFile();
            //Задача 4
            (new DirectoryWriter(4, "directory.txt")).Execute();
            //Задача 5
            (new TodoOrganizer.TodoOrganizer(5)).Execute();
            Console.ReadKey();

        }
    }
}
