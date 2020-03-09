using Microsoft.AspNetCore.Mvc;
using ScrabbleScore.Models;
using System;

namespace Scrabble.Controllers
{
  public class HomeController : Controller
  {
    [Route("/input")]
    public ActionResult Word() { return View(); }

    [Route("/output")]
    public ActionResult Score(string word)
    {
      int score = ScrabbleScorer.Score(word);
      return View(score);
    }
  }
}