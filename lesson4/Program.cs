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

        public enum Seasons { Winter, Spring, Summer, Autumn }
        public string[] russianSeasons = { "Зима", "Весна", "Лето", "Осень" };

        static (string name, int age) GetClientInfo()
        {
            string name = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());
            return (name, age);
        }

        //Вспомогательная функция для вывода ошибки на консоль
        public static void DisplayError(string message) 
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        
        //Вспомогательная функция вывода заголовка задачи
        public static void ShowTaskTitle(string taskName) 
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($" ======== {taskName} ========");
            Console.ResetColor();
        }

        //Вспомогательная функция преобразования строки в int32 с подстановкой значения по умолчанию и выводом ошибки если что не так
        public static int StrToInt(string str, int defaultValue=0) 
        {
            int result;
            if (!Int32.TryParse(str, out result))
            {
                result = defaultValue;
                DisplayError($"введенный набор символов <{str}> не является целым числом и будет представлен значением {defaultValue}");
            }
            return result;
        }

        //Задание 1. Вспомогательная функция к заданию 
        public static string GetFullName(string firstName, string lastName, string patronymic) 
        {
            return $"{firstName} {patronymic} {lastName}";
        }
        //Задание 1. Основная функция
        public static void Task1()
        {
            ShowTaskTitle("Задание 1");
            string[][] names = new string[3] [];
            names[0] = new string[3] { "Петров", "Валериан", "Афанасьевич"};
            names[1] = new string[3] { "Иванов", "Никодим", "Петрович" };
            names[2] = new string[3] { "Павлова", "Ольга", "Олеговна" };

  
            for (int i = 0; i < names.Length; i++) {
                Console.WriteLine((i+1)+". "+GetFullName(names[i][1], names[i][0], names[i][2]));
            }
        }

        //Задание 2. Вспомогательная функция получения строки чисел и перевод ее в массив чисел. Можно конечно и сразу сумму посчитать, но сделал так
        //defaultValue - значение по умолчанию введенного "числа", если не пройдет перобразование строки в число
        public static int[] GetNumbers(char separator, int defaultValue = 0) 
        { 
            string[] vs = Console.ReadLine().Split(separator);
            int[] numbers = new int[vs.Length];
            for (int i = 0; i < vs.Length; i++) 
            {
               numbers[i] = StrToInt(vs[i]);
            }
            return numbers;
        }

        //Задание 2. Суммирование элементов массива
        public static int ArraySumm(int[] array) 
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++) 
            {
                sum += array[i];
            }
            return sum;
        }

        //Задание 2. Основная функция
        public static void Task2() 
        {
            ShowTaskTitle("Задание 2");
            Console.WriteLine("Введите набор целых чисел, разделенных пробелами для подсчета их суммы:");
            Console.WriteLine("-------------------------------\n Итоговая сумма введенного ряда: " + ArraySumm(GetNumbers(' ', 0)));
        }

        //Задание 3. Проверка номера месяца на валидность
        public static bool MonthNumberValid(int month)
        { 
            return (month >= 1)&&(month<=12);
        }


        //Задание 3. Преобразование номера месяца в сезон
        public static Seasons GetSeason() 
        {
            int i = StrToInt(Console.ReadLine(),1);
            if (!MonthNumberValid(i)) 
            {
                DisplayError($"Значение номера месяца {i} не входит в диапазон 1-12, значение сезона будет приведено для месяца с номером 1 (январь)");
                return Seasons.Winter;
            }
            i = i == 12 ? 0 : i;  //Ну, это потому что времена года не всовпадают о фазе с кварталами. Приводим в порядок
            i = (int) (i / 3); 
            return (Seasons) i;
        }


        //Задание 3. Преобразование английского сезона в русский
        public static string GetRusSeason(Seasons season, string[] translationArray)
        {
            return translationArray[(int)season];
        }


        //Задание 3. Основная функция
        //Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца .....
        public static void Task3() 
        {
            ShowTaskTitle("Задание 3");
            Console.WriteLine("Введине номер месяца от 1 до 12, где 1-Январь, 12 - Декабрь:");
            
            Console.WriteLine(GetRusSeason(GetSeason, russianSeasons));
        }


        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            Task3();
            Console.ReadKey  ();


        }
    }
}
