namespace Scores
{
  public class ScoreStats
  {
    static public void Main()
    {
      List<int> scores = new();
      Console.WriteLine("How many games did you have last season and would like to get their stats?");
      int numberOfGames = int.Parse(Console.ReadLine());
      for(int i = 1; i <= numberOfGames; i++)
      {
        Console.WriteLine("How many points did you get for game {0}", i);
        int points = int.Parse(Console.ReadLine());
        scores.Add(points);
      }
      int lowest = GetLowestScore(scores);
      int highest = GetHighestScore(scores);
      int sum = GetSumOfScores(scores);
      int average = GetAverageScore(scores); 
      Console.WriteLine("Lowest scoring game -> {0}", lowest);
      Console.WriteLine("Highest scoring game -> {0}", highest);
      Console.WriteLine("Total season points -> {0}", sum);
      Console.WriteLine("Average points per game -> {0}", average);
    }

    public static int GetLowestScore(List<int> scores) => scores.Min();

    public static int GetHighestScore(List<int> scores) => scores.Max();

    public static int GetSumOfScores(List<int> scores) => scores.Sum();

    public static int GetAverageScore(List<int> scores) => (int)scores.Average();
  }
}