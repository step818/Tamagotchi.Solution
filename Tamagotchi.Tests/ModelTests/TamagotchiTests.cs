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
      Pet newTama = new Pet("", 4, 5, 5);
      Assert.AreEqual(typeof(Pet), newTama.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsInputName()
    {
      string name = "Panatda";
      Pet newTama = new Pet(name, 4, 5, 5);
      string result = newTama.GetName();
      Assert.AreEqual(result, "Panatda");
    }
    [TestMethod]
    public void GetId_ReturnsIdOfPet_Int()
    {
      string name = "Panatda";
      Pet newTama = new Pet(name, 4, 5, 5);
      int result = newTama.GetId();
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectPet_Pet()
    {
      string name1 = "Panatda";
      string name2 = "Alex";
      Pet newTama = new Pet(name1, 5, 5, 5);
      Pet newTama2 = new Pet(name2, 5, 5, 5);
      Pet result = Pet.Find(2);
      Assert.AreEqual(newTama2, result);
    }
    [TestMethod]
    public void GetFoodLevel_ReturnsLevelOfHunger_Int()
    {
      string name1 = "panatda";
      int foodLevel = 5;
      Pet newTama = new Pet(name1, foodLevel, 5, 5);
      int result = newTama.GetFoodLevel();
      Assert.AreEqual(result, 5);
    }
    [TestMethod]
    public void GetAttentionLevel_ReturnsLevelOfAttention_Int()
    {
      string name = "";
      int foodLevel = 5;
      int attentionLevel = 5;
      Pet newTama = new Pet(name, foodLevel, attentionLevel, 5);
      int result = newTama.GetAttentionLevel();
      Assert.AreEqual(result, 5);
    }
    [TestMethod]
    public void GetRestLevel_ReturnsLevelOfRest_Int()
    {
      int restLevel = 5;
      Pet newTama = new Pet("", 5, 5, restLevel);
      int result = newTama.GetRestLevel();
      Assert.AreEqual(result, 5);
    }


  }
}
