using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheGame.Models;
using System.Collections.Generic;
using System;

namespace TheGame.Tests
{
  [TestClass]
  public class RPScissorsGameTest
  {
    [TestMethod]
    public void WhoWins_Values_RockVsScissors()
    {
      RPScissorsGame inputValues = new RPScissorsGame("Rock", "Scissors");
      string winner = inputValues.WhoWins();
      Console.WriteLine(winner);

      Assert.AreEqual("Player One wins", winner);
    }

    [TestMethod]
    public void WhoWins_Values_RockVsPaper()
    {
      RPScissorsGame inputValues = new RPScissorsGame("Rock", "Paper");
      string winner = inputValues.WhoWins();
      Console.WriteLine(winner);

      Assert.AreEqual("Player Two wins", winner);
    }

    [TestMethod]
    public void WhoWins_the_Same_Values_()
    {
      RPScissorsGame inputValues = new RPScissorsGame("Scissors", "Scissors");
      string winner = inputValues.WhoWins();
      Console.WriteLine(winner);

      Assert.AreEqual("Nobody wins", winner);
    }

    [TestMethod]
    public void WhoWins_the_Invalid_Values_()
    {
      RPScissorsGame inputValues = new RPScissorsGame("notPaper", "notScissors");
      string winner = inputValues.WhoWins();
      Console.WriteLine(winner);

      Assert.AreEqual("Play again!", winner);
    }

  }
}
