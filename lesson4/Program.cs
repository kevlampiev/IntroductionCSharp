using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    internal class Program
    {
        enum Numbers { Five = 5}

        static (string name, int age) GetClientInfo()
        {
            string name = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());
            return (name, age);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Ваше имя и возраст:");
            (string userName, int userAge)= GetClientInfo();
            Console.WriteLine($"Привет, {userName}! До пенсии тебе осталось {65 - userAge}");

            Console.WriteLine("-----------------");
            object[] objects = { 1, 2, "3", "Four", Numbers.Five, true };
            for (int i = 0; i < objects.Length; i++) 
            { 
                Console.WriteLine(objects[i].ToString());
            }
            Console.ReadKey  ();


        }
    }
}
