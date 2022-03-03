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
            Monday = 0b_1000000,
            Tuesday = 0b_0100000,
            Wednesday = 0b_0010000,
            Thursday = 0b_0001000,
            Friday = 0b_0000100,
            Saturday = 0b_0000010,
            Sunday = 0b_0000001
        }
        static void Main(string[] args)
        {
            //Вывод заголовка
            Console.Write("".PadRight(15, ' '));
            foreach (string subject in Enum.GetNames(typeof(Schedule)))
            {
                Console.Write(subject.PadRight(14, ' ') + " ");
            }
            Console.WriteLine();

            //Вывод строк
            foreach (Weekday wd in Enum.GetValues(typeof(Weekday)))
            {
                Console.Write(wd.ToString().PadLeft(12, ' '));
                foreach (Schedule day in Enum.GetValues(typeof(Schedule)))
                {
                    byte byteDay = (byte)day;
                    byte byteWD = (byte)wd;
                    if ((byteDay & byteWD) > 0)
                    {
                        Console.Write("1".PadLeft(3, ' ').PadRight(15, ' '));
                    }
                    else
                    {
                        Console.Write(" ".PadRight(15, ' '));
                    }

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
