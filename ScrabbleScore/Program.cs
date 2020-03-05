using System;
using ScrabbleScore.Models;

namespace ScrabbleScore
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter your word to calculate it's Scrabble score.");
      string userInput = Console.ReadLine();
      try
      {
        int score = ScrabbleScorer.Score(userInput);
        Console.WriteLine($"'{userInput}' is worth {score} points.");
      }
      catch (Exception ex)
      {
        Console.WriteLine("ERROR: {0}", ex.Message);
      }
      Main();
    }
  }
}