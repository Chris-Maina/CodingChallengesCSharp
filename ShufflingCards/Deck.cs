namespace shufflingcards
{
  public class Deck
  {
    enum CardSuit { HEARTS, DIAMONDS, SPADES, CLUBS }

    public List<string> cards;

    public Deck()
    {
      cards = new List<string>();

      foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
      {
        for (int cardNum = 2; cardNum < 11; cardNum++)
        {
          cards.Add($"{cardNum} of suit {suit}");
          cards.Add($"A of suit {suit}");
          cards.Add($"J of {suit}");
          cards.Add($"Q of {suit}");
          cards.Add($"K of {suit}");
        }
      }
    }
  }
  
}