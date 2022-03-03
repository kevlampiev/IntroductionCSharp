using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string shopName = "ООО 'Электротовары'";
            DateTime orderDate = DateTime.Now;
            byte posCont = 5; //количество позиций в чеке
            double posSumm = 11000.33; //Сумма 

            shopName = shopName.PadRight(33,' ');

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"| Продавец: {shopName}|");
            Console.WriteLine($"| Дата фискального чека: {orderDate} |");
            Console.WriteLine("|".PadRight(45,' ')+"|");
            Console.WriteLine("|".PadRight(45, ' ') + "|");
            Console.WriteLine($"| Количество товара: {posCont:d1}".PadRight(45,' ') + "|");
            Console.WriteLine($"| Стоимость, руб: {posSumm:f2}".PadRight(45, ' ') + "|");
            Console.WriteLine($"| в т.ч. НДС, руб: {(posSumm/6):f2}".PadRight(45, ' ') + "|");
            Console.WriteLine("----------------------------------------------");

            Console.ReadKey();
        }
    }
}
