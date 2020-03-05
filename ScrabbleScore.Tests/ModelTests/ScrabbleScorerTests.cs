using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScrabbleScorerTests
  {
    [TestMethod]
    public void Score_ScoreReturnsAnInt_Int()
    {
      //arrange
      // act
      //assert
      Assert.AreEqual(1, ScrabbleScorer.Score("A"));
    }
    [TestMethod]
    public void Score_ScoreCountsLetters_Int()
    {
      Assert.AreEqual(3, ScrabbleScorer.Score("rat"));
    }

    [TestMethod]
    public void Score_ScoreCountsBonusLetters_Int()
    {
      Assert.AreEqual(13, ScrabbleScorer.Score("quit"));
    }

    [TestMethod]
    public void Score_ScoreCountsAllBonusLetters_Int()
    {
      Assert.AreEqual(33, ScrabbleScorer.Score("ADBFKJQ"));
    }
  }
}