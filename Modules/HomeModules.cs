using Nancy;
using HangMan.Objects;
using System.Collections.Generic;

namespace HangMan
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["home.html"];
      };
      Get["/start"] = _ => {
        Game newGame = new Game();
        return View["index.cshtml", newGame];
      };
      Post["/response"] = _ => {
        Game currentGame = Game.GetCurrentGame();
        currentGame.PassTurn(Request.Form["letter"]);
        return View["index.cshtml", currentGame];
      };
    }
  }
}
