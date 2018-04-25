using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TheGame.Models;
using System;

namespace TheGame.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("game")]
    public ActionResult Check()
    {
      RPScissorsGame inputValues = new RPScissorsGame(Request.Form["playerOne"], Request.Form["playerTwo"]);
      string winner = inputValues.WhoWins();
      Console.WriteLine(winner);
      return View("Result", winner);
    }

  }
}
