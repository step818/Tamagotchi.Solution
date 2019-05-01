using System;
using System.Collections.Generic;

namespace Tamagotchi.Models
{
    public class Tamagotchi
    {
        private string _name;
        private int _id;
        private static List<Tamagotchi> _instances = new List<Tamagotchi>{};

        public Tamagotchi (string name)
        {
          _name = name;
          _instances.Add(this);
          _id = _instances.Count;
        }

        public string GetName()
        {
          return _name;
        }
  }
}
