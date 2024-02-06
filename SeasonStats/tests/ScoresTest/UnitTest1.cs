using Scores;
namespace ScoresTest;

[TestClass]
public class ProgramUnitTests
{
  readonly List<int> scores = new() { 9, 2, 7, 4, 6, 8, 20 };
    
    [TestMethod]
    public void ReturnsLowestScore()
    {
      int result = ScoreStats.GetLowestScore(scores);
      int expected = scores[1];
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void ReturnsHighestScore()
    {
      int result = ScoreStats.GetHighestScore(scores);
      int expected = scores.Last();
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void ReturnsSumOfScores()
    {
      int result = ScoreStats.GetSumOfScores(scores);
      int expected = scores.Aggregate(0, (total, next) => total += next);
      Assert.AreEqual(result, expected);
    }

  [TestMethod]
  public void ReturnsAverageOfScores()
  {
    int result = ScoreStats.GetAverageScore(scores);
    int sum = scores.Aggregate(0, (total, next) => total += next);
    int expected = sum/scores.Count();
    Assert.AreEqual(result, expected);
  }
}