using System;

namespace lesson3a
{
    internal enum ShipPlacementDirection
    {
        vertical,
        horisontal
    }

    internal struct Warship
    {
        public int colStart;
        public int rowStart;
        public int deckSize;
        public ShipPlacementDirection direction;

        public int colEnd()
        {
            return colStart + (deckSize - 1) * Convert.ToByte(direction == ShipPlacementDirection.horisontal);
        }

        public int rowEnd()
        {
            return rowStart + (deckSize - 1) * Convert.ToByte(direction == ShipPlacementDirection.vertical);
        }
    }

    internal class Program
    {
        //Задача 1. Вспомогательная функция для генерации матрицы псевдослучайных чисел
        private static int[,] GenerateMatrix(byte rows, byte cols)
        {
            var random = new Random();
            var array = new int[rows, cols];
            for (var i = 0; i < rows; i++)
            for (var j = 0; j < cols; j++)
                array[i, j] = random.Next(100);
            return array;
        }

        //Задача 1. Вспомогательная функция для печати матрицы
        private static void PrintMatrix(int[,] array)
        {
            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var k = 0; k < array.GetLength(1); k++) Console.Write(array[i, k].ToString().PadLeft(5, ' '));
                Console.WriteLine();
            }
        }

        //Задача 1. Вывод диагональных элементов матрицы. Общая функция
        private static void task1()
        {
            byte rows = 4;
            byte cols = 3;
            var matrix = GenerateMatrix(rows, cols);

            Console.WriteLine("Matrix:");
            PrintMatrix(matrix);
            Console.WriteLine("diagonal elements list:");
            for (var j = 0; j < Math.Min(matrix.GetLength(0), matrix.GetLength(1)); j++)
                Console.WriteLine($"{matrix[j, j]}  {matrix[j, matrix.GetLength(1) - j - 1]}");
        }

        //Задание 2. Вспомогательная функция вывода справочника на экран
        public static void printPhoneBook(string[,] phoneBook)
        {
            Console.WriteLine();
            for (var i = 0; i < phoneBook.GetLength(0); i++)
            {
                Console.Write(i + 1);
                for (var j = 0; j < phoneBook.GetLength(1); j++) Console.Write(phoneBook[i, j].PadLeft(20, ' '));
                Console.WriteLine();
            }
        }

        //Задание 2. Вспомогательная функция добавления элемента в справочник
        public static string[,] addElement(string[,] phoneBook)
        {
            Console.WriteLine();
            Console.WriteLine("Enter a name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Enter a phone number: ");
            var phone = Console.ReadLine();

            var newArray = new string[phoneBook.GetLength(0) + 1, phoneBook.GetLength(1)];
            for (var i = 0; i < phoneBook.GetLength(0); i++)
            for (var j = 0; j < phoneBook.GetLength(1); j++)
                newArray[i, j] = phoneBook[i, j];
            newArray[phoneBook.GetLength(0), 0] = name;
            newArray[phoneBook.GetLength(0), 1] = phone;

            return newArray;
        }

        //Задание 2. Телефонный справочник. Общая функция
        public static void task2()
        {
            string[,] phoneBook =
            {
                { "Alex", "111-1111" },
                { "Brendon", "222-2222" },
                { "Corina", "333-3333" },
                { "Dan", "444-4444" },
                { "Eva", "555-5555" }
            };

            while (true)
            {
                Console.WriteLine("Press i for inserting new contact, q- for exit... ");
                printPhoneBook(phoneBook);
                var key = Console.ReadKey().KeyChar;
                switch (key)
                {
                    case 'q': return;
                    case 'i':
                        phoneBook = addElement(phoneBook);
                        break;
                }
            }
        }

        //Задание 3. Написать слово "Hello ... " в обратном порядке
        public static void task3()
        {
            var someString = "Hello from task 3!";
            var reversString = "";
            for (var i = someString.Length - 1; i >= 0; i--) reversString += someString[i];
            Console.WriteLine($"{someString}  =>  {reversString}");
        }


        //Задание 4. Вспомогательная функция которая проверяет влезает ли корабль с заданными характеристиками в доску

        public static bool doesShipFit(byte[,] battlefield, Warship warship)
        {
            var axisSize = Math.Min(battlefield.GetLength(0), battlefield.GetLength(1));

            //Если корабль вылезает за поле - сразу говорим что не вписывается. В принципе, лишняя проверка, но все может быть
            if (warship.colEnd() >= battlefield.GetLength(0)) return false;
            if (warship.rowEnd() >= battlefield.GetLength(1)) return false;

            //если корабль влезает в поле - смотрим, не мещает ли его расположение расположениям уже вписаных кораблей
            if (warship.direction == ShipPlacementDirection.horisontal)
            {
                for (var i = warship.colStart; i <= warship.colEnd(); i++)
                    if (battlefield[i, warship.rowStart] != 0)
                        return false;
            }
            else
            {
                for (var i = warship.rowStart; i <= warship.rowEnd(); i++)
                    if (battlefield[warship.colStart, i] != 0)
                        return false;
            }

            //если не выбило до сих пор, то корабль вписывается
            return true;
        }

        //Возвращает случайно сгенерированный корабль, который может перекрываться с другими кораблями, но укладывается внутри доски
        public static Warship getRandWarship(byte[,] battlefield, int deckSize)
        {
            var r = new Random();
            var axisSize = Math.Min(battlefield.GetLength(0), battlefield.GetLength(1));
            var direction = (ShipPlacementDirection)Convert.ToByte(r.Next(0, 100) % 2 == 1);
            var startRow = r.Next(0,
                axisSize - Convert.ToByte(direction == ShipPlacementDirection.vertical) * deckSize -
                1); //случайная стартовая позиция по строкам 
            var startCol = r.Next(0,
                axisSize - Convert.ToByte(direction == ShipPlacementDirection.horisontal) * deckSize -
                1); //случайная стартовая позиция по колонкам


            return new Warship { colStart = startCol, rowStart = startRow, deckSize = deckSize, direction = direction };
        }

        //Находит случайную точку, куда можно вписать корабль длиной deckSize за maxIterations итераций
        public static Warship getWarshipPos(byte[,] battlefield, int deckSize, int maxIterations = 100)
        {
            var iteration = 0;
            var success = false;
            var warship = getRandWarship(battlefield, deckSize);
            while (iteration < maxIterations)
            {
                warship = getRandWarship(battlefield, deckSize);
                if (doesShipFit(battlefield, warship))
                {
                    success = true;
                    break;
                }
                iteration++;
            }
            if (success) return warship;
            return new Warship { colStart = 0, rowStart = 0, deckSize = 0 };
        }


        //Задание 4. Вспомогательная функция установки корабля с длиной палубы deck 
        public static void addWarship(ref byte[,] battlefield, int deck)
        {
            var warship = getWarshipPos(battlefield, deck);

            var c0 = Math.Max(warship.colStart - 1, 0);
            var c1 = Math.Min(warship.colEnd() + 1, battlefield.GetLength(0) - 1);
            var r0 = Math.Max(warship.rowStart - 1, 0);
            var r1 = Math.Min(warship.rowEnd() + 1, battlefield.GetLength(1) - 1);

            for (var i = c0; i <= c1; i++)
            for (var j = r0; j <= r1; j++)
                battlefield[i, j] = 1;

            for (var i = warship.colStart; i <= warship.colEnd(); i++)
            for (var j = warship.rowStart; j <= warship.rowEnd(); j++)
                battlefield[i, j] = 2;
        }

        //Задание 4. Вспомогательная функция генерации доски и расстановки флота
        public static byte[,] getBattleField(int axisSize = 10)
        {
            var battleField = new byte[axisSize, axisSize];
            for (var i = 0; i < axisSize; i++)
            for (var j = 0; j < axisSize; j++)
                battleField[i, j] = 0;
            //расстановка флота. 

            //Warship warship = getWarshipPos(battleField, 4);
            for (var deck = 4; deck > 0; deck--)
            for (var count = 4 - deck; count >= 0; count--)
                addWarship(ref battleField, deck);

            return battleField;
        }


        //Задание 4. Вспомогательная функция отрисовки доски
        public static void drawBattlefield(byte[,] battlefield)
        {
            var letters = "ABCDEFGHIJKLMN0PQRSTUVWXYZ";

            //заголовок
            Console.WriteLine("== Sea battle ==");
            Console.Write(" ");
            for (var i = 0; i < battlefield.GetLength(0); i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" " + letters[i] + " ");
                Console.ResetColor();
            }

            Console.WriteLine();

            //Основное поле
            for (var i = 0; i < battlefield.GetLength(1); i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{i}".PadLeft(2, ' '));
                Console.ResetColor();
                for (var j = 0; j < battlefield.GetLength(0); j++)
                    if (battlefield[i, j] != 2)
                    {
                        Console.Write(" . ");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write("   ");
                        Console.ResetColor();
                    }
                Console.WriteLine();
            }
        }

        //Задание 4. Расставить корабли по клеткам игры "Морской бой". Общая функция
        public static void task4(int axisSize = 10)
        {
            var battleField = getBattleField();
            drawBattlefield(battleField);
        }

        private static void Main(string[] args)
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