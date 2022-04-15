using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KEvlampiev.TerminalUtils;

namespace lesson8a
{
    internal class Program
    {
        static void GetUserData() 
        {
            Properties.Settings.Default.Username = TerminalApp.AskString("Введите Ваше имя");
            Properties.Settings.Default.UserAge = TerminalApp.AskInteger("Введите Ваш возраст");
            Properties.Settings.Default.UserOccupation = TerminalApp.AskString("Введите вашу профессию");
            Properties.Settings.Default.Save();
        }

        static void DisplayUserData() 
        {
            Console.WriteLine("Я тебя уже знаю");
            Console.WriteLine($"Твое имя: {Properties.Settings.Default.Username}");
            Console.WriteLine($"Ивой возраст: {Properties.Settings.Default.UserAge}");
            Console.WriteLine($"Твоя профессия {Properties.Settings.Default.UserOccupation}");

        }
        static void Main(string[] args)
        {
            TerminalApp.DisplayTaskHeader("Домашнее задание к Уроку 8", "Евлампиев К.В.");
            string appDescription = System.Reflection.Assembly.GetExecutingAssembly().GetName().FullName;

            TerminalApp.DisplayHeader($" Информация о приложении {appDescription}");
            

            TerminalApp.DisplayHeader(Properties.Settings.Default.Greetings);
            if (String.IsNullOrEmpty(Properties.Settings.Default.Username)) 
            { 
                GetUserData();
            } 
            else 
            {
                DisplayUserData();
            }

           TerminalApp.WaitBeforeExit();

        }
    }
}
