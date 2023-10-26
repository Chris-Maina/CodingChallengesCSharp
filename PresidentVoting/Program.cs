namespace PresidentVoting
{
  public class Program
  {
    public static void Main()
    {
      // Ask age
      Console.WriteLine("Please enter your age.");
      string? ageInput = Console.ReadLine();
      int age;
      while (string.IsNullOrEmpty(ageInput) || string.IsNullOrWhiteSpace(ageInput) || !int.TryParse(ageInput, out age))
      {
        Console.WriteLine("Invalid input. Please enter correct age value.");
        ageInput = Console.ReadLine();
      };

      Console.WriteLine("Age is {0}", age);
      try
      {
        int result = CalculatePresidents(age);
        Console.WriteLine("You've voted for {0} presidents(s)", result);
      }
      catch (ArgumentOutOfRangeException ex)
      {
        Console.WriteLine(ex.Message);
      }

    }

    public static int CalculatePresidents(int age)
    {
      // check if he/she is of voting age
      if (age < 18)
        throw new ArgumentOutOfRangeException(nameof(age), "You're under age. Cannot vote.");
      
      int votingYears = age - 18;
      double result = votingYears / 4;
      return (int)Math.Floor(result);
    }
  }
  
}