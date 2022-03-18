using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2c1
{
    internal class Program
    {
        enum Schedule
        {
            Csharp = 0b_0101000,
            JS = 0b_1010000,
            Html = 0b_0000100,
            Php = 0b_0010001
        }

        enum Weekday
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 4,
            Thursday = 8,
            Friday = 16,
            Saturday = 32,
            Sunday = 64
        }
        static void Main(string[] args)
        {
            //Вывод заголовка
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("STUDY SCHEDULE \n".PadLeft(70,' '));
            Console.Write("    Subject  |".PadRight(15, ' '));
            foreach (string day in Enum.GetNames(typeof(Weekday)))
            {
                Console.Write("   "+day.PadRight(10, ' ') + "|");
            }
            Console.WriteLine("\n".PadRight(114,'-'));

            //Вывод строк
            foreach (Schedule subject in Enum.GetValues(typeof(Schedule)))
            {
                Console.Write(subject.ToString().PadLeft(12, ' ')+" | ");
                foreach (Schedule day in Enum.GetValues(typeof(Weekday)))
                {
                    byte byteDay = (byte)day;
                    byte byteWD = (byte)subject;
                    if ((byteDay & byteWD) > 0)
                    {
                        Console.Write("lesson".PadLeft(8, ' ').PadRight(13, ' ')+"|");
                    }
                    else
                    {
                        Console.Write(" ".PadRight(13, ' ')+"|");
                    }

                }
                Console.WriteLine("\n".PadRight(114,'-'));
            }
            Console.ReadKey();
        }
    }
}
