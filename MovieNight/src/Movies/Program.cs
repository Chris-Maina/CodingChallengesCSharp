﻿namespace Movies
{
  class Program
  {
    public static void Main()
    {
      List<Movie> movies = new List<Movie>()
      {
        new Movie("The Batman", "PG-13", 85),
        new Movie("Morbius", "PG-13", 17),
        new Movie("Spider-Man: No Way Home", "PG-13", 93)
      };

      Console.WriteLine("Hit ENTER for a list of superhero movies!");
      Console.ReadKey();

      foreach(Movie movie in movies)
      {
        Console.WriteLine(movie.ToString() + "\n");
      }
      Console.ReadKey();
    }
  }
}
