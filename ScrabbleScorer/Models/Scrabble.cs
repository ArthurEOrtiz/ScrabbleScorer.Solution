using System.Collections.Generic;

namespace ScrabbleScorer
{
  public class Scrabble
  {
    public static string SplitWord(string word)
    {
      string input = word;
      string[] output = input.ToCharArray();
      return output;
    }
    //get word,
    //pass it through a loop to get the letters in an array. 
    //pass it though the a letter dictionary to get the point value of letter, 
    //then pass that through a sum function to get the sum of the letters, 
    //return to use
  }
}
