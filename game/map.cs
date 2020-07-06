using System;
using System.Collections.Generic;
namespace game.models
{
  class Map
  {
    List<Room> MapRooms = new List<Room>();
    public Map(Room[] rooms)
    {
      for (int i = 0; i < rooms.Length; i++)
      {
        MapRooms.Add(rooms[i]);
      }
    }
  }
}