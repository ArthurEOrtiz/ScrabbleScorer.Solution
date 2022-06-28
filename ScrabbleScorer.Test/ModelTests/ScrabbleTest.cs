using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScorer;

namespace ScrabbleScorer.Tests
{
  [TestClass]
  public class ScrabbleTests
  {
    [TestMethod]
    public void StringSplit_TurnWordIntoArrayOfIndividualLetters_ArrayOfLetters()
    {
      Scrabble scrabbleWord = new Scrabble(); 
      string singleWord = "dog";
      char[] result = {"d","o","g"};
      Assert.AreEqual(singleWord.SplitWord(), result )
    }

  }
}