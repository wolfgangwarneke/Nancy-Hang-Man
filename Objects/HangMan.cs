using System.Collections.Generic;

namespace HangMan.Objects
{
  public class Game
  {
    private int _turn = 0;
    private bool _inGame = false;
    private static List<Game> _gamesPlayed = new List<Game> {};
    private bool _isFirstVisit = true;
    private List<string> _wordBank = new List<string>(new string[] { "element", "tidal", "scotch" });
    private List<string> _word;
    private string _encodedWord;

    public Game (bool inGame, string letterGuess)
    {
      _turn ++;
      _inGame = inGame;
    }

    public void startingGame(int index)
    {
      string convert = _wordBank[index];
      _word = convert.ToCharArray();
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

    public string GetInterfaceLetterList(List<string> wordToEncode)
    {
      wordToEncode[_currentTurn] = "?" ;
      for (i=_currentTurn+1; i < wordToEncode.Count; i++)
      {
        wordToEncode[i] = "_";
      }

    }
  }
}
