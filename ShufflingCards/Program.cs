namespace shufflingcards
{
  class Program
  {
    public static void Main()
    {
      Console.WriteLine("Hit ENTER to shuffle the deck and deal the top 5 cards!");
      Console.ReadKey();

      var freshDeck = new Deck();
      var shuffledDeck = Shuffle(freshDeck.cards);
      Deal(new Stack<string>(shuffledDeck));
      Console.ReadKey();

    }

    public static List<string> Shuffle(List<string> cards)
    {
      Random random = new Random();
      for (int i = 0; i < cards.Count; i++)
      {
        int randomIndex = random.Next(i, cards.Count);

        string tempCard = cards[i];
        cards[i] = cards[randomIndex];
        cards[randomIndex] = tempCard;
      }
      return cards;
    }

    public static void Deal(Stack<string> shuffledCards)
    {
      Console.WriteLine("Your hand:");
      for (int i = 0; i < 2; i++)
      {
        Console.WriteLine($" -> {shuffledCards.Pop()}");
      }

      Console.WriteLine("\nBurn top card ...");
      _ = shuffledCards.Pop();

      Console.WriteLine("\nHole cards:");
      for (int i = 0; i < 3; i++)
      {
        Console.WriteLine($"  -> {shuffledCards.Pop()}");
      }

      Console.WriteLine("\nBetting starts!");
    }
  }
}
