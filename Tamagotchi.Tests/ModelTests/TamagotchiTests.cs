using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tamagotchi.Models;
using System;

namespace Tamagotchi.TestTools
{
  [TestClass]
  public class TamagotchiTest : IDisposable
  {
    public void Dispose()
    {
      Pet.ClearAll();
    }
    [TestMethod]
    public void TamagotchiConstructor_CreatesNewTamagotchi_Tamagotchi()
    {
      Pet newTama = new Pet("");
      Assert.AreEqual(typeof(Pet), newTama.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsInputName()
    {
      string name = "Panatda";
      Pet newTama = new Pet(name);
      string result = newTama.GetName();
      Assert.AreEqual(result, "Panatda");
    }
    [TestMethod]
    public void GetId_ReturnsIdOfPet_Int()
    {
      string name = "Panatda";
      Pet newTama = new Pet(name);
      int result = newTama.GetId();
      Assert.AreEqual(1, result);
    }

  }
}
