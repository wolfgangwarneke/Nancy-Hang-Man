using System.Collections.Generic;

namespace HangMan.Objects
{
  public class Game
  {
    private string _testWord = "superfly";
    private string _gameWord;
    private static Game _currentGame;
    private List<string> _lettersGuessed = new List<string> {};
    private string _letterGuessedThisTurn;
    private int _wrongGuesses = 0;
    private string _imageHtml = "<img src='/Content/img/alive.png' alt=''>";
    private List<string> _imageList = new List<string> {
      "<img src='/Content/img/alive.png' alt=''>",
      "<img src='/Content/img/alive.png' alt=''>",
      "<img src='/Content/img/alive.png' alt=''>",
      "<img src='/Content/img/alive.png' alt=''>",
      "<img src='/Content/img/alive.png' alt=''>",
      "<img src='/Content/img/alive.png' alt=''>",
      "<img src='/Content/img/alive.png' alt=''>"
      };
    private List<string> _correctGuesses = new List<string> {};
    private List<string> _outputWord = new List<string> {};

    public Game()
    {
      this.SetGameWord();
      _currentGame = this;
    }

    public void PassTurn(string letterGuessed)
    {
      _lettersGuessed.Add(letterGuessed);
      if (_gameWord.Contains(letterGuessed)) {
        _correctGuesses.Add(letterGuessed);
      } else {
        _currentGame.SetImageHtml();
        _wrongGuesses++;
      }
    }

    public string GetGameWord()
    {
      return _gameWord;
    }

    public void SetGameWord()
    {
      _gameWord = _testWord;
    }

    public static Game GetCurrentGame()
    {
      return _currentGame;
    }

    public List<string> GetLettersGuessed()
    {
      return _lettersGuessed;
    }

    // public void SetLetterGuessedThisTurn(string letter)
    // {
    //   _letterGuessedThisTurn = letter;
    // }
    public int GetWrongGuesses()
    {
      return _wrongGuesses;
    }
    public List<string> GetCorrectGuesses()
    {
      return _correctGuesses;
    }


    public void SetImageHtml()
    {
      _imageHtml = _imageList[_wrongGuesses];
    }

    public string GetImageHtml()
    {
      return _imageHtml;
    }

    public List<string> GetWordOutput()
    {
      _outputWord.Clear();
      for (var i = 0; i < _gameWord.Length; i++) {
        _outputWord.Add("_");
      }
      foreach( var letter in _correctGuesses ) {
        int index = _gameWord.IndexOf(letter);
        if (index != -1) {
          _outputWord[index] = letter;
        }
      }
      return _outputWord;
    }
  }
}
