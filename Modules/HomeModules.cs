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
        Game gameState = new Game(false);
        return View["index.cshtml", gameState];
      };
      Get["/start"] = _ => {
        Game gameState = new Game(true);
        return View["index.cshtml", gameState];
      };
      Post["/response"] = _ => {
        Game gameState = new Game(true, Request.Form["answer"]);
        return View["index.cshtml", gameState];
      };
    }
  }
}
