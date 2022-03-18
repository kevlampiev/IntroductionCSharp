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
            string shopName = "ООО 'ДНС Ритейл'";
            string shopAddress = "115372, г.Москва, ул. Бирблевская, д.51, 1";
            string docNumber = "E-09945591";
            DateTime orderDate = DateTime.Now;

            string productName = "Кабель мини USB-USB 2.0 FinePower";
            byte posCont = 5; //количество позиций в чеке
            double posSumm = 11000.33; //Сумма 

            byte stdLength = 60;

            Console.WriteLine("-".PadRight(60,'-'));
            Console.WriteLine($"| Продавец: {shopName}".PadRight(stdLength-1, ' ')+"|");
            Console.WriteLine($"| Продавец: {shopAddress}".PadRight(stdLength - 1, ' ') + "|");
            Console.WriteLine($"| Дата фискального чека: {orderDate}".PadRight(stdLength-1, ' ')+"|");
            Console.WriteLine("|".PadRight(stdLength - 1, ' ') + "|");
            Console.WriteLine("|".PadRight(stdLength - 1, ' ') + "|");
            Console.WriteLine($"| Наименовение товара: {productName}".PadRight(stdLength - 1, ' ') + "|");
            Console.WriteLine($"| Количество товара: {posCont:d1}".PadRight(stdLength - 1, ' ') + "|");
            Console.WriteLine($"| Стоимость, руб: {posSumm:f2}".PadRight(stdLength - 1, ' ') + "|");
            Console.WriteLine($"| в т.ч. НДС, руб: {(posSumm/6):f2}".PadRight(stdLength - 1, ' ') + "|");
            Console.WriteLine("".PadRight(stdLength, '-'));

            Console.ReadKey();
        }
    }
}
