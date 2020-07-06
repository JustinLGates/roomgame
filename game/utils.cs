using System;
using System.Threading;
using System.Collections.Generic;

namespace game.utils
{
  class Utils
  {
    public void typeMsg(string msg)
    {
      int speed = 10;
      for (int i = 0; i < msg.Length; i++)
      {
        Console.Write(msg[i]);
        Thread.Sleep(speed);
      }
      Console.WriteLine("");
    }
    public void clear()
    {
      Console.Clear();
    }
  }
}