// Decompiled with JetBrains decompiler
// Type: lesson7.Lohotron
// Assembly: lesson7aa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B8C75854-8613-43F6-9DB7-25ED5DF0DB92
// Assembly location: D:\CSharpProj\geekbrains\Introduction\lesson7aa\bin\Release\cracked.exe

using System;

namespace lesson7
{
  internal class Lohotron
  {
    private int _winningBid;
    private int _bidAmount;

    public int Remain { get; set; }

    public int Bet { get; set; }

    public int WinningBid => this._winningBid;

    public int BidAmount => this._bidAmount;

    public bool ReadyToPlay => this.Remain >= this.BidAmount && this.Bet >= 0 && this.Bet <= 9;

    public Lohotron(int bidAmount)
    {
      this._bidAmount = Math.Max(bidAmount, 10);
      this._winningBid = -1;
      Console.WriteLine(string.Format("БОЛЬШАЯ ЛОТЕРЕЯ.\nВ каждом туре разыгрываем {0} руб. 00 коп.!!!!", (object) this.BidAmount));
    }

    public void GetMoney()
    {
      Console.WriteLine("Введите сумму пополнения счета: ");
      int result;
      if (int.TryParse(Console.ReadLine(), out result))
        this.Remain += result;
      else
        Console.WriteLine("введена некорректная сумма");
    }

    public void GetBet()
    {
      Console.WriteLine("Введите cвое число удачи (0-9): ");
      int result;
      if (int.TryParse(Console.ReadLine(), out result))
      {
        if (result >= 0 && result < 10)
        {
          Console.WriteLine("Ставка принята");
          this.Bet = result;
        }
        else
          Console.WriteLine("Некорректная ставка");
      }
      else
        Console.WriteLine("Введеное хначение не является числом");
    }

    public void ShowRemain() => Console.WriteLine(string.Format("Остаток вашего счета составляет {0}", (object) this.Remain));

    private void GetWinningBid()
    {
      this._winningBid = new Random().Next(0, 9);
      Console.WriteLine(string.Format("Ваша ставка {0}, выпало {1} ", (object) this.Bet, (object) this.WinningBid));
    }

    public void TurnTheWheel()
    {
      if (!this.ReadyToPlay)
      {
        Console.WriteLine(" Пополните счет и/или сделайте ставку");
      }
      else
      {
        this.GetWinningBid();
        if (this.Bet != this.WinningBid)
          ;
        Console.WriteLine("Вы выиграли");
        this.Remain += this.BidAmount;
        this.ShowRemain();
        Console.WriteLine("Для продолжения нажмите любую клавишу");
        Console.ReadKey();
      }
    }

    public void SayGoodbye()
    {
      this.ShowRemain();
      Console.WriteLine("До следующих встреч .... ");
    }
  }
}
