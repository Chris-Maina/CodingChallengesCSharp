namespace gamenight
{
  public class Player
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public int LatestScore {get; set; }
    public int PrevScore {get; set; }

    public Player(string firstName, string lastName, int latestScore, int prevScore)
    {
      FirstName = firstName;
      LastName = lastName;
      LatestScore = latestScore;
      PrevScore = prevScore;
    }

    public override string ToString()
    {
      return $"{FirstName} {LastName} improved";
    }
  }

}