using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2a
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            try
            {
                int someNumber;
                Console.WriteLine("Enter a integer number: ");
                someNumber = int.Parse(Console.ReadLine());
                if (someNumber % 2 == 0)
                {
                    Console.WriteLine($"the number {someNumber} is even");
                }
                else {
                    Console.WriteLine($"the number {someNumber} is odd");
                }
                Console.WriteLine("press any key to exit");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}
