using System;
using System.Text.RegularExpressions;

namespace ScrabbleScore.Models
{
  public class ScrabbleScorer
  {
    //Creates Regex ;

    public static Regex OnePoint = new Regex("[AEIOULNRST]", RegexOptions.IgnoreCase);

    public static Regex TwoPoints = new Regex("[DG]", RegexOptions.IgnoreCase);

    public static Regex ThreePoints = new Regex("[BCMP]", RegexOptions.IgnoreCase);

    public static Regex FourPoints = new Regex("[FHVWY]", RegexOptions.IgnoreCase);

    public static Regex FivePoints = new Regex("K", RegexOptions.IgnoreCase);

    public static Regex EightPoints = new Regex("[JX]", RegexOptions.IgnoreCase);

    public static Regex TenPoints = new Regex("[QZ]", RegexOptions.IgnoreCase);

    public static Regex NonAlpha = new Regex("[^a-zA-Z]");


    public static int Score(string userword)
    {
      if (userword.Length == 0)
      {
        throw new Exception("Your word length cannot be zero.");
      }
      else if (NonAlpha.Matches(userword).Count > 0)
      {
        throw new Exception("Scrabble does not have scores for non-letter characters.");
      }
      int score = 0;
      MatchCollection onePointMatches = OnePoint.Matches(userword);
      MatchCollection twoPointMatches = TwoPoints.Matches(userword);
      MatchCollection threePointMatches = ThreePoints.Matches(userword);
      MatchCollection fourPointMatches = FourPoints.Matches(userword);
      MatchCollection fivePointMatches = FivePoints.Matches(userword);
      MatchCollection eightPointMatches = EightPoints.Matches(userword);
      MatchCollection tenPointMatches = TenPoints.Matches(userword);

      foreach (Match item in onePointMatches)
      {
        score += 1;
      }
      foreach (Match item in twoPointMatches)
      {
        score += 2;
      }
      foreach (Match item in threePointMatches)
      {
        score += 3;
      }
      foreach (Match item in fourPointMatches)
      {
        score += 4;
      }
      foreach (Match item in fivePointMatches)
      {
        score += 5;
      }
      foreach (Match item in eightPointMatches)
      {
        score += 8;
      }
      foreach (Match item in tenPointMatches)
      {
        score += 10;
      }
      return score;
    }
  }
}