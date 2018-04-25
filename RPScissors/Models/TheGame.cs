using System.Collections.Generic;
using System;

namespace TheGame.Models
{
  public class RPScissorsGame
  {
    private string _playerOneChoice;
    private string _playerTwoChoice;

    private List<string> _allCombs = new List<string>();

    public RPScissorsGame(string firstValue, string secondValue)
    {
      _playerOneChoice = firstValue;
      _playerTwoChoice = secondValue;
    }

    public string GetPlayerOneValue()
    {
      return _playerOneChoice;
    }
    public string GetPlayerTwoValue()
    {
      return _playerTwoChoice;
    }

    public string WhoWins()
    {
      string result = "";
      if ((_playerOneChoice=="rock" && _playerTwoChoice=="scissors") || (_playerOneChoice=="paper" && _playerTwoChoice=="rock") || (_playerOneChoice=="scissors" && _playerTwoChoice=="paper"))
      {
        result = "Player One wins";
      }
      else if ((_playerTwoChoice=="rock" && _playerOneChoice=="scissors") || (_playerTwoChoice=="paper" && _playerOneChoice=="rock") || (_playerTwoChoice=="scissors" && _playerOneChoice=="paper"))
      {
        result = "Player Two wins";
      }
      else if (_playerOneChoice==_playerTwoChoice)
      {
        result = "Nobody wins";
      }
      else
      {
        result = "Play again!";
      }
      return result;
    }

  }
}
