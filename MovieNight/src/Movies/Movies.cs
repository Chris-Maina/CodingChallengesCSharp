using System;
namespace Movies
{
  public class Movie
  {
    public string title;
    public string rating;
    public int reviewScore;

    public Movie(string title, string rating, int reviewScore)
    {
      this.title = title;
      this.rating = rating;
      this.reviewScore = reviewScore;
    }

    public override string ToString()
    {
      string result = $"-> {title}\n \tRated {rating}\n \t{reviewScore}% on RT";
      if (reviewScore >= 75)
        return result + " - Certified Fresh!";
      return result;
    }
  }
}