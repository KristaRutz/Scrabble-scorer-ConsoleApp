using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScrabbleScorerTests
  {

    [TestMethod]
    public void ScrabbleScorer_ConstructMethodConstructsA_ScrabbleScorer()
    {
      //arrange
      ScrabbleScorer testScore = new ScrabbleScorer();
      // act
      int result = testScore.OnePoint;
      //assert
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void Score_ScoreReturnsAnInt_Int()
    {
      //arrange
      // act
      //assert
      Assert.AreEqual(1, ScrabbleScorer.Score("Test"));
    }

  }
}