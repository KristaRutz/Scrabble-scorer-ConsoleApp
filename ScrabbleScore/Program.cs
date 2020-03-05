using System;

namespace ScrabbleScore
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter your word to calculate it's Scrabble score.");
      string userInput = Console.ReadLine();
      int score = 0;
      Console.WriteLine($"'{userInput}' is worth {score} points.");
    }
  }
}