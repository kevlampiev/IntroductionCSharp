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
            (new StringsWriter(1, "task5.1.txt")).Execute();
            (new TimeWriter(2, "task5.2.txt")).Execute();
            DigitsWriter dr = new DigitsWriter(3, "task5.3.dat");
            dr.Execute();
            dr.ShowDigitFile();

            Console.ReadKey();

        }
    }
}
