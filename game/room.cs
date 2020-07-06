using System;
namespace game.models
{
  class Room
  {
    public bool isOpen { get; set; }
    public string Description { get; set; }
    public Room(string description, bool open)
    {
      isOpen = open;
      Description = description;
    }

    public Room(string description)
    {
      isOpen = true;
      Description = description;
    }
  }
}