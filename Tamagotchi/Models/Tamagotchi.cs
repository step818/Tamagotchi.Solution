using System;
using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class Pet
  {
    private string _name;
    private int _id;
    private int _foodLevel;
    private int _attentionLevel;
    private int _restLevel;
    private static List<Pet> _collection = new List<Pet>{};

    public Pet (string name, int foodLevel, int attentionLevel, int restLevel)
    {
      _name = name;
      _collection.Add(this);
      _id = _collection.Count;
      _foodLevel = foodLevel;
      _attentionLevel = attentionLevel;
      _restLevel = restLevel;
    }
    public static List<Pet> GetAll()
    {
      return _collection;
    }
    public string GetName()
    {
      return _name;
    }
    public int GetId()
    {
      return _id;
    }
    public static Pet Find(int tag)
    {
      return  _collection[tag-1];
    }
    public int GetFoodLevel()
    {
      return _foodLevel;
    }
    public int GetAttentionLevel()
    {
      return _attentionLevel;
    }
    public int GetRestLevel()
    {
      return _restLevel;
    }

    ///
    public static void ClearAll()
   {
     _collection.Clear();
   }

  }

}
