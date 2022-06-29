using System.Collections.Generic;
using System; 

namespace ScrabbleScorer
{
  public class Scrabble
  {
    //declare within a method 
    public LetterValues(string userInput)
    {
      int charValue = 0;

      Dictionary<char, int> letterValues = new Dictionary<char, int>()
      {{"A", 1}, {"E", 1}, {"I", 1}, {"O", 1}, {"U", 1}, {"L", 1}, {"N", 1}, {"R", 1}, {"S", 1}, {"T", 1}, {"D", 2}, {"G", 2}, {"B", 3}, {"C", 3}, {"M", 3}, {"P", 3}, {"F", 4}, {"H", 4}, {"V", 4}, {"W", 4}, {"Y", 4}, {"K", 5}, {"J", 8}, {"X", 8}, {"Q", 10}, {"Z", 10}};

      for (int index = 0; index < userInput.length; index++)
      {
        if (userInput.Conatins(letterValues[index]))
        {
          return charValue += letterValue[index]
        }
      }
      
      

   
    }
    
    //get word,
    //pass it through a loop to get the letters in an array. 
    //pass it though the a letter dictionary to get the point value of letter, 
    //then pass that through a sum function to get the sum of the letters, 
    //return to use
  }
}