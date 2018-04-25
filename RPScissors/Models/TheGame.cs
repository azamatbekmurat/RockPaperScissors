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
      if ((_playerOneChoice=="Rock" && _playerTwoChoice=="Scissors") || (_playerOneChoice=="Paper" && _playerTwoChoice=="Rock") || (_playerOneChoice=="Scissors" && _playerTwoChoice=="Paper"))
      {
        result = "Player One wins";
      }
      else if ((_playerTwoChoice=="Rock" && _playerOneChoice=="Scissors") || (_playerTwoChoice=="Paper" && _playerOneChoice=="Rock") || (_playerTwoChoice=="Scissors" && _playerOneChoice=="Paper"))
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
