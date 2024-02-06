using System;
namespace VowelCount
{
  public class CountVowels
  {
    static public void Main()
    {
      Console.WriteLine("Please type a word or sentence to get it's vowel count");
      string? wordOrSentence = Console.ReadLine();
      while (String.IsNullOrWhiteSpace(wordOrSentence))
      {
        Console.WriteLine("You did not enter anything. Please type a word or sentence.");
        wordOrSentence = Console.ReadLine();
      }

      CountVowels countVowels = new CountVowels();
      Console.WriteLine("Score is {0}", countVowels.GetVowelCount(wordOrSentence));
    }

    public int GetVowelCount(string wordOrSentence) 
    {
      int score = 0;
      Dictionary<string, int> scoreSheet = new Dictionary<string, int>{
        {"A", 1},
        {"E", 2},
        {"I", 3},
        {"O", 4},
        {"U", 5},
        {"Y", 9},
      };
      foreach (char letter in wordOrSentence.ToUpper())
      {
        int point;
        if(scoreSheet.TryGetValue(letter.ToString(), out point))
        score += point;
      }
      return score;
    } 
  }
}