using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3a
{
    internal class Program
    {
        
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

        //Задание 2. Вывод справочника на экран
        public static void printPhoneBook(string[,] phoneBook) 
        {
            for (int i = 0; i < phoneBook.GetLength(0); i++) {
                Console.Write(i);
                for (int j = 0; j < phoneBook.GetLength(1); j++) {
                    Console.Write(phoneBook[i, j].PadLeft(20, ' '));
                }
                Console.WriteLine();
            }
        }

        //Задание 2. Добавление элемента в справочник
        public static string[,] addElement(string[,] phoneBook) 
        {
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

        //Задание 2. Телефонный справочник
        static void task2() 
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

        static void Main(string[] args)
        {
            Console.WriteLine("Task #1 \n =========================================================");
            task1();
            Console.WriteLine("Task #2 \n =========================================================");
            task2();
            
        }
    }
}
