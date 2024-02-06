namespace gamenight
{
  public class MainClass
  {
    public static List<Player> players = new List<Player>()
    {
      new Player("Harrison", "Ferrone", 233, 198),
      new Player("Alex", "Ferrone", 219, 202),
      new Player("Haley", "Ferrone", 241, 222),
      new Player("Jogn", "Doe", 144, 198),
      new Player("Sally", "Doe", 233, 198),
      new Player("Frank", "Smith", 189, 234),
      new Player("Joan", "Smith", 211, 178),
    };
    public static void Main()
    {
      Console.WriteLine("Enter an improvement index to see which game night attendees fit the bill:");
      int targetImprovement = int.Parse(Console.ReadLine());

      PrintStats(targetImprovement);
      Console.ReadKey();
    }

    public static void PrintStats(int targetImprovement)
    {
      var gameQuery = 
        from player in players
        let improvement = player.LatestScore - player.PrevScore
        where improvement > targetImprovement
        group player by player.LastName[0] into playerGroup
        orderby playerGroup.Key
        select playerGroup;


      foreach (var playerGroup in gameQuery)
      {
        Console.WriteLine($"\n{playerGroup.Key}");
        foreach (Player player in playerGroup)
        {
          Console.WriteLine($"{player.FirstName} {player.LastName} has improved by more than {targetImprovement}");
        }
      }
    }
  }
}
