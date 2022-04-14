using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    internal class Lohotron
    {

        private int _winningBid;
        private int _bidAmount;


        /// <summary>
        /// Остаток кошелька игрока
        /// </summary>
        public int Remain { get; set; }
        /// <summary>
        /// На какое число поставил игрок
        /// </summary>
        public int Bet { get; set; }
        /// <summary>
        /// Выпавшее число
        /// </summary>
        public int WinningBid { get => _winningBid; }
        /// <summary>
        /// Сумма ввыигрыша / потери за 1 ход
        /// </summary>
        public int BidAmount { get => _bidAmount; }

        public bool ReadyToPlay { get => (Remain >= BidAmount && Bet >= 0 && Bet <= 9); }

        public Lohotron(int bidAmount)
        {
            _bidAmount = Math.Max(bidAmount, 10);
            _winningBid = -1; //Заведомо нерабочая комбинация 
            Console.WriteLine($"БОЛЬШАЯ ЛОТЕРЕЯ.\nВ каждом туре разыгрываем {BidAmount} руб. 00 коп.!!!!");
        }

        /// <summary>
        /// Функция запроса пополнения баланса
        /// </summary>
        public void GetMoney()
        {
            Console.WriteLine("Введите сумму пополнения счета: ");
            int m;
            if (int.TryParse(Console.ReadLine(), out m))
            {
                Remain += m;
            }
            else
            {
                Console.WriteLine("введена некорректная сумма");
            }
        }


        public void GetBet()
        {
            Console.WriteLine("Введите cвое число удачи (0-9): ");

            if (int.TryParse(Console.ReadLine(), out int bet))
            {
                if (bet >= 0 && bet < 10)
                {
                    Console.WriteLine("Ставка принята");
                    Bet = bet;
                }
                else
                {
                    Console.WriteLine("Некорректная ставка");
                }
            }
            else
            {
                Console.WriteLine("Введеное хначение не является числом");
            }
        }


        /// <summary>
        /// Просто показывает остаток
        /// </summary>
        public void ShowRemain()
        {
            Console.WriteLine($"Остаток вашего счета составляет {Remain}");
        }

        private void GetWinningBid()
        {
            Random rnd = new Random();
            _winningBid = rnd.Next(0, 9);
            Console.WriteLine($"Ваша ставка {Bet}, выпало {WinningBid} ");

        }

        /// <summary>
        /// Основная функция
        /// </summary>
        public void TurnTheWheel()
        {
            if (!ReadyToPlay)
            {
                Console.WriteLine(" Пополните счет и/или сделайте ставку");
                return;
            }

            GetWinningBid();

            if (Bet == WinningBid)
            {
                Console.WriteLine("Вы выиграли");
                Remain += BidAmount;
            }
            else
            {
                Console.WriteLine("Вы проиграли");
                Remain -= BidAmount;
            }
            ShowRemain();
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();
        }

        public void SayGoodbye()
        {
            ShowRemain();
            Console.WriteLine("До следующих встреч .... ");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            char command;
            Lohotron lohotron = new Lohotron(100);
            while (true)
            {
                Console.Clear();
                lohotron.ShowRemain();
                Console.WriteLine("Введите код команды (1-внести деньги, 2-сделать ставку, 3 - играть, 4 - выйти): ");
                command = Console.ReadKey().KeyChar;
                Console.SetCursorPosition(0, 2);
                switch (command)
                {
                    case '1': lohotron.GetMoney(); break;
                    case '2': lohotron.GetBet(); break;
                    case '3': lohotron.TurnTheWheel(); break;
                    case '4': lohotron.SayGoodbye(); return;

                    default:
                        Console.WriteLine("Нет такой команды");
                        break;
                }

            }
        }
    }
}
