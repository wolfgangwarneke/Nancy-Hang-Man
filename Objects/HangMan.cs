using System.Collections.Generic;

namespace HangMan.Objects
{
  public class Game
  {
    private int _turn = 0;
    private bool _inGame = false;
    private static List<Game> _gamesPlayed = new List<Game> {};
    private bool _isFirstVisit = true;

    public Game (bool inGame, string letterGuess)
    {
      _turn ++;
      _inGame = inGame;
    }

    public bool HasWon()
    {
      return false;
    }

    public bool Loser()
    {
      return false;
    }

    public bool IsFirstVisit()
    {
      bool status;
      if (_isFirstVisit) {
        status = true;
        _isFirstVisit = false;
      }
      return status;
    }

    public string CurrentHangmanImage()
    {
      return "<img src='broken'>";
    }

    public string GetInterfaceLetterList()
    {
      return "Wh?_";
    }
  }
}
