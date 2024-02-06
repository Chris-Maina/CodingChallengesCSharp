namespace TipCalculator;
class TipCalculator
{
  public static void Main(string[] args)
  {
    Console.WriteLine("Enter the cost of your meal to calculate tip options:");
    var input = int.Parse(Console.ReadLine());

    // MARK: Result
    var tips = CalculateTip(input);
    Console.WriteLine($"10% -> {tips.low} \n17.5% -> {tips.mid} \n25% -> ${tips.high}");
    Console.ReadKey();
  }

  public static (string low, string mid, string high) CalculateTip(int cost) =>
    (
      string.Format("{0:00.00}", Math.Round(cost * 0.1, 2)), 
      string.Format("{0:00.00}", Math.Round(cost * 0.175, 2)), 
      string.Format("{0:00.00}", Math.Round(cost * 0.25, 2)));
}
