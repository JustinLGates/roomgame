using System;
using System.Collections.Generic;
using System.Threading;
namespace game
{
  class Game
  {
    bool isRunning { get; set; }
    void start()
    {
      isRunning = true;
    }
    void stop()
    {
      isRunning = false;
    }
    public Game()
    {
      Console.Clear();
      var originalColor = Console.ForegroundColor;
      Console.ForegroundColor = ConsoleColor.Yellow;
      string msg = "Do you want to play a game....";

      start();
      run();
    }
    void run()
    {

    }
  }
}