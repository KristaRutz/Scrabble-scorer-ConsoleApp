using System;
using System.Text.RegularExpressions;

namespace ScrabbleScore.Models
{
  public class ScrabbleScorer
  {
    //public int OnePoint = 1;

    public static Regex OnePoint = new Regex("[AEIOULNRST]", RegexOptions.IgnoreCase);

    public static int Score(string userword)
    {
      int score = 0;
      MatchCollection onePointMatches;
      onePointMatches = OnePoint.Matches(userword);
      foreach (Match item in onePointMatches)
      {
        score += 1;
      }
      return score;
    }
  }
}