using System;
using System.Collections.Generic;
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
    public game()
    {
      Console.WriteLine("Do you want to play a game.");
      start();
      run();
    }
    void run()
    {

    }
  }
}