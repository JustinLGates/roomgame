using System;
using System.Collections.Generic;
namespace game.models
{
  class Map
  {
    public Room CurrentRoom { get; set; }
    List<Room> AllRooms = new List<Room>()
    {

    };
    public Map()
    {
      Room startRoom = new Room("The place where the game starts");
      Room room1 = new Room("The first new room");
      Room room2 = new Room("The locked room", false);
      AllRooms.Add(startRoom);
      AllRooms.Add(room1);
      AllRooms.Add(room2);
      CurrentRoom = startRoom;
    }
    public void move(string roomName)
    {
      CurrentRoom = AllRooms[roomName];
    }
  }
}