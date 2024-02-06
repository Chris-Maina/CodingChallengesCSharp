using Movies;
namespace MovieTests;

[TestClass]
public class MovieTest
{
    [TestMethod]
    public void Movie_ToString_Returns_Title_Rating_ReviewScore()
    {
      Movie movie = new Movie("Morbius", "PG-13", 17);
      string expected = $"-> {movie.title}\n \tRated {movie.rating}\n \t{movie.reviewScore}% on RT";
      Assert.AreEqual(movie.ToString(), expected);
    }

    [TestMethod]
    public void Movie_ToString_Returns_Certified_Fresh()
    {
      Movie movie = new Movie("The Batman", "PG-13", 85);
      string expected = $"-> {movie.title}\n \tRated {movie.rating}\n \t{movie.reviewScore}% on RT - Certified Fresh!";
      Assert.AreEqual(movie.ToString(), expected);
    }
}
