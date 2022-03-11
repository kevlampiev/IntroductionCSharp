using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3a
{
    internal class Program
    {
        //Задача 1. Вспомогательная функция для генерации матрицы псевдослучайных чисел
        static int[,] GenerateMatrix(byte rows, byte cols)
        { 
            Random random = new Random();
            int[,] array = new int[rows, cols];
            for (int i = 0; i < rows; i++)
                for(int j = 0; j < cols; j++)
                {
                    array[i, j] = random.Next(100);
                }
            return array;
        }

        //Задача 1. Вспомогательная функция для печати матрицы
        static void PrintMatrix(int[,] array) 
        {
            for (int i = 0; i < array.GetLength(0); i++) { 
                for (int k = 0; k < array.GetLength(1); k++)
                { 
                    Console.Write(array[i, k].ToString().PadLeft(5,' '));
                }
                Console.WriteLine();
            }
        }

        //Задача 1. Вывод диагональных элементов матрицы. Общая функция
        static void task1() 
        {
            byte rows = 4;
            byte cols = 3;
            int[,] matrix = GenerateMatrix(rows, cols);

            Console.WriteLine("Matrix:");
            PrintMatrix(matrix);
            Console.WriteLine("diagonal elements list:");
            for (int j = 0; j < Math.Min(matrix.GetLength(0), matrix.GetLength(1)); j++)
            {
                Console.WriteLine($"{matrix[j, j]}  { matrix[j, matrix.GetLength(1) - j - 1]}");
            }

        }

        //Задание 2. Вспомогательная функция вывода справочника на экран
        public static void printPhoneBook(string[,] phoneBook) 
        {
            Console.WriteLine();
            for (int i = 0; i < phoneBook.GetLength(0); i++) {
                Console.Write(i+1);
                for (int j = 0; j < phoneBook.GetLength(1); j++) {
                    Console.Write(phoneBook[i, j].PadLeft(20, ' '));
                }
                Console.WriteLine();
            }
        }

        //Задание 2. Вспомогательная функция добавления элемента в справочник
        public static string[,] addElement(string[,] phoneBook) 
        {
            
            Console.WriteLine();
            Console.WriteLine("Enter a name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter a phone number: ");
            string phone = Console.ReadLine();
            
            string[,] newArray = new string[phoneBook.GetLength(0) + 1, phoneBook.GetLength(1)];
            for (int i = 0; i < phoneBook.GetLength(0); i++) {
                for (int j = 0; j < phoneBook.GetLength(1); j++) { 
                    newArray[i, j] = phoneBook[i, j];
                }
            }
            newArray[phoneBook.GetLength(0), 0] = name;
            newArray[phoneBook.GetLength(0), 1] = phone;

            return newArray;
        }

        //Задание 2. Телефонный справочник. Общая функция
        public static void task2() 
        {
            string[,] phoneBook = { {"Alex", "111-1111" },
                                    { "Brendon", "222-2222"},
                                    { "Corina", "333-3333"},
                                    { "Dan", "444-4444"},
                                    { "Eva", "555-5555"}
            };

            while (true) {
                Console.WriteLine("Press i for inserting new contact, q- for exit... ");
                printPhoneBook(phoneBook);
                char key = Console.ReadKey().KeyChar;
                switch (key) {
                    case 'q': return;
                    case 'i': phoneBook = addElement(phoneBook);
                        break;
                }
            }
        
        }

        //Задание 3. Написать слово "Hello ... " в обратном порядке
        public static void task3() 
        {
            string someString = "Hello from task 3!";
            string reversString = "";
            for (int i = someString.Length-1; i >= 0; i--)
            {
                reversString += someString[i];
            }
            Console.WriteLine($"{someString}  =>  {reversString}");
        }


        //Задание 4. Вспомогательная функция которая проверяет влезает ли характер с заданными характеристиками в доску

        public static bool doesShipFit(byte[,] battlefield, int col, int row, int deck, bool direction) 
        {
            int axisSize =Math.Min(battlefield.GetLength(0), battlefield.GetLength(1));
            //Если корабль вылезает за поле - сразу говорим что не вписывается
            int col0 = Math.Max(col -1,0);
            int colM = col0 + deck * Convert.ToByte(direction)+1;
            if (colM > battlefield.GetLength(0)) return false;

            int row0 = Math.Max(row - 1, 0);
            int rowM = row0 + deck * Convert.ToByte(!direction) +1;
            if (colM > battlefield.GetLength(0)) return false;

            //если корабль влезает в поле - смотрим, не мещает ли его расположение расположениям уже вписаных кораблей

            for (int i = col0; i < colM; i++) {
                for (int j = row0; j < rowM; j++) { 
                    if (battlefield[i,j] != 0) return false;
                }
            }

            return true;
        }


        //Задание 4. Вспомогательная функция установки корабля с длиной палубы deck 
        public static bool addWarchip(ref byte[,] battlefield, int deck) 
        {
            bool direction = (r.Next(100) > 50); //Для каждого корабля генерим случайную величину стартовой точки и направления true - вправо, false - вниз
            int axisSize=Math.Min(battleship.GetLength(0),battleship.GetLength(1));
            int startRow = r.Next(1, axisSize - Convert.ToByte(!direction) * deck); //случайная стартовая позиция по строкам 
            int startCol = r.Next(1, axisSize - Convert.ToByte(direction) * deck); //случайная стартовая позиция по колонкам
            //Пробуем наугад поставить корабль с этими характеристиками если нет, смещаем корабль по колонкам на 1 позицию или по строкам на 1 позицию и снова проверяем
            while (!doesShipFit(battlefield, startCol, startRow, deck, direction)) {
                startCol++;
                if (startCol >= axisSize) {
                    startCol = 0;
                    startRow++;
                    if (startRow >= axisSize) return false;
                };
            }
            
            //определили куда можно вписать корабль (иначе бы вылетели), вписываем
            for (int i)

            return true;
        }

        //Задание 4. Вспомогательная функция генерации доски и расстановки флота
        public static byte[,] getBattleField(int axisSize = 10) 
        { 
            char[,] battleField = new char[axisSize, axisSize];
            for (int i = 0; i < axisSize; i++) {
                for (int j = 0; j < axisSize; j++) {
                    battleField[i, j] = '0';
                }
            }
            //расстановка флота. 
            for (int deck = 4; deck > 0; deck--) {
                Random r = new Random();
                for (int i = 0; i <= 4-deck; i++)
                {
                    
                    byte direction = Convert.ToByte(r.Next(100)>50);
                    int startRow = r.Next(1, axisSize - direction * deck);
                    int startCol = r.Next(1, axisSize - direction*deck);
                    for (int k = 0; k < deck; k++) {
                        int col=startCol+k*direction;
                        int row=startRow+k*direction;
                        battleField[row,col] = '2';


                    }
                }
            }


            return battleField;
        }

        

        //Задание 4. Вспомогательная функция отрисовки доски
        public static void drawBattlefield(char[,] battlefield, byte[][,] warships) 
        {
            string letters = "ABCDEFGHIJKLMN0PQRSTUVWXYZ";


            //заголовок
            Console.WriteLine("== Sea battle ==");
            Console.Write(" ");
            for (int i = 0; i < battlefield.GetLength(0); i++) 
            { 
                Console.Write(" "+letters[i]);
            }
            Console.WriteLine();

            //Основное поле
            for (int i = 0; i < battlefield.GetLength(1); i++) {
                Console.Write($"{i}".PadLeft(2,' '));
                for (int j = 0; j < battlefield.GetLength(0); j++) 
                {
                    Console.Write(" "+battlefield[i, j]);
                }
                Console.WriteLine();
            }
        }

        //Задание 4. Расставить корабли по клеткам игры "Морской бой". Общая функция
        public static void task4(int axisSize=10) 
        { 
            char [,] battleField = getBattleField();
            drawBattlefield(battleField, null);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Task #1 \n =========================================================");
            task1();
            Console.WriteLine("Task #2 \n =========================================================");
            task2();
            Console.WriteLine("Task #3 \n =========================================================");
            task3();
            Console.WriteLine("Task #4 \n =========================================================");
            task4();
            Console.ReadKey();

        }
    }
}
