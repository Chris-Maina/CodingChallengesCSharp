using System.Text.RegularExpressions;

namespace EmailValidation
{
  public class Program
  {
    public static void Main()
    {
      string response = string.Empty;
      while (response != "Email is valid")
      {
        // Ask user to enter their email
        Console.WriteLine("Enter the email address you'd like to validate:");
        string? emailInput = Console.ReadLine();
        response = ValidateEmail(emailInput);
        Console.WriteLine(response);
      };
    }

    public static string ValidateEmail(string? email)
    {
      if(string.IsNullOrEmpty(email) || string.IsNullOrWhiteSpace(email))
        return "Email cannot be empty or contain whitespace";

      string startWithPattern = @"\A([0-9]|\W+)";
      if (Regex.IsMatch(email, startWithPattern))
        return "Email can't start with a number or symbol";

      string endWithPattern = @"\.com\Z";
      if (!Regex.IsMatch(email, endWithPattern))
        return string.Format("Email must end with {0}.", ".com");

      string containsAtSymbol = @"\@";
      if (!Regex.IsMatch(email, containsAtSymbol))
        return string.Format("Email must contain {0} symbol.", "@");
      
      return "Email is valid";
      
    }
  }
}
