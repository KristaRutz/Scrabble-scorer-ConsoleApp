using System;
using ScrabbleScore.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace ScrabbleScore
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .UseStartup<Startup>()
        .Build();

      host.Run();
    }
    // public static void Main()
    // {
    //   Console.WriteLine("Enter your word to calculate it's Scrabble score.");
    //   string userInput = Console.ReadLine();
    //   try
    //   {
    //     int score = ScrabbleScorer.Score(userInput);
    //     Console.WriteLine($"'{userInput}' is worth {score} points.");
    //   }
    //   catch (Exception ex)
    //   {
    //     Console.WriteLine("ERROR: {0}", ex.Message);
    //   }
    //   Main();
    // }
  }
}