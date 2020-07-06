using System;
using System.Collections.Generic;
using game.utils;
using game.models;
namespace game
{
  class Game
  {

    Map map = new Map();
    Utils log = new Utils();
    public string input { get; set; }
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
      Console.ForegroundColor = ConsoleColor.Green;
      string msg = "Do you want to play a game.... {y/n}";
      log.typeMsg(msg);
      input = Console.ReadLine();
      Console.Clear();
      if (input == "y")
      {
        log.typeMsg("ok good ... what is your name again?");
        input = Console.ReadLine();
        log.typeMsg($"ah, yes {input}. I remember you...");
        start();
        run();
      }
      else
      {
        Console.Clear();
        log.typeMsg("you died ...");
      }
    }
    void run()
    {
      log.typeMsg("here are the rules...");
      log.typeMsg("one don't die. two ");
      log.typeMsg("there are no more rules");
      log.typeMsg("Press enter to continue");
      input = Console.ReadLine();
      Console.Clear();
      while (isRunning)
      {

        log.typeMsg("options lookaround {l} move {m} pickup item{p} quit {q}");
        input = Console.ReadLine();

        switch (input)
        {
          case "l":
            log.clear();
            log.typeMsg(map.CurrentRoom.Description);

            break;
          case "m":
            log.clear();
            break;
          case "p":
            log.clear();
            break;
          case "q":
            log.clear();
            log.typeMsg("goodbye.....");
            stop();
            break;
          default:
            log.clear();
            log.typeMsg(".... that wasnt a valid option you died");
            stop();
            break;
        }

      }
      log.typeMsg("Thanks for playing.... You died");
    }
  }
}