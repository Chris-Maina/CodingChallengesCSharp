namespace FibonacciSequence;

public class Fibonacci
{
  public static void Main()
  {
    Console.WriteLine("Enter a number you'd like to get the Fibonacci series");
    int length = int.Parse(Console.ReadLine());
    List<int> sequence = CalculateFibonacci(length);
    foreach (int number in sequence)
    {
      Console.Write($"{number},");
    }
  }

  public static List<int> CalculateFibonacci(int length)
  {
    List<int> fibonnaci = new List<int>();
    if (length <= 0)
    {
      return fibonnaci;
    }
    if (length == 1)
    {
      fibonnaci.Add(0);
      return fibonnaci;
    }
    fibonnaci.Add(0);
    fibonnaci.Add(1);
    for (int i = 2; i < length; i++)
    {
      int sum = fibonnaci[i-1] + fibonnaci[i-2];
      fibonnaci.Add(sum);
    }
    return fibonnaci;
  }
}
