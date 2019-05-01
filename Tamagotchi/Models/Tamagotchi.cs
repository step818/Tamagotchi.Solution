using System;
using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class Pet
  {
    private string _name;
    private int _id;
    private static List<Pet> _collection = new List<Pet>{};

    public Pet (string name)
    {
      _name = name;
      _collection.Add(this);
      _id = _collection.Count;
    }
    public string GetName()
    {
      return _name;
    }
    public int GetId()
    {
      return _id;
    }
    ///
    public static void ClearAll()
   {
     _collection.Clear();
   }
  }

}
