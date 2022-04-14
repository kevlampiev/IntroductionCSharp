// Decompiled with JetBrains decompiler
// Type: lesson7.Program
// Assembly: lesson7aa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B8C75854-8613-43F6-9DB7-25ED5DF0DB92
// Assembly location: D:\CSharpProj\geekbrains\Introduction\lesson7aa\bin\Release\cracked.exe

using System;

namespace lesson7
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      Lohotron lohotron = new Lohotron(100);
      while (true)
      {
        Console.Clear();
        lohotron.ShowRemain();
        Console.WriteLine("Введите код команды (1-внести деньги, 2-сделать ставку, 3 - играть, 4 - выйти): ");
        char keyChar = Console.ReadKey().KeyChar;
        Console.SetCursorPosition(0, 2);
        switch (keyChar)
        {
          case '1':
            lohotron.GetMoney();
            continue;
          case '2':
            lohotron.GetBet();
            continue;
          case '3':
            lohotron.TurnTheWheel();
            continue;
          case '4':
            goto label_5;
          default:
            Console.WriteLine("Нет такой команды");
            continue;
        }
      }
label_5:
      lohotron.SayGoodbye();
    }
  }
}
