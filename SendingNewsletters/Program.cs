using System.Text.Json;

namespace sendingnewsletters
{
  class Program
  {
    public static void Main()
    {
      string jsonString =
        @"{
          ""Name"": ""Weekly Comics Newsletter!"",
          ""Admin"": ""Jane Porter"",
          ""CreatedOn"": ""2022-01-01"",
          ""Subscribers"": [
            {
              ""Name"": ""Jack Powell"",
              ""ID"": 231,
              ""Email"": ""jpowell0@hplussport.com""
            },
            {
              ""Name"": ""Emily Garcia"",
              ""ID"": 221
            },
            {
              ""Name"": ""Richard Dean"",
              ""ID"": 211
            },
            {
              ""Name"": ""Jane Larson"",
              ""ID"": 201,
              ""Email"": ""jlarsone@hplussport.com""  
            }
          ]
        }";

      Console.WriteLine("Hit ENTER to find out who's missing an email!");
      var customerIDs = DecryptJSON(jsonString);
      foreach (var id in customerIDs)
      {
        Console.WriteLine($"Send missing info prompt to user ID: {id}");
      }

      Console.ReadKey();
    }

    public static List<int> DecryptJSON(string jsonString)
    {
      List<int> subscribersWithMissingEmails = new List<int>();
      using (JsonDocument jsonDocument = JsonDocument.Parse(jsonString))
      {
        JsonElement root = jsonDocument.RootElement;
        JsonElement subscribers = root.GetProperty("Subscribers");

        foreach (JsonElement subscriber in subscribers.EnumerateArray())
        {
          if (subscriber.TryGetProperty("Email", out JsonElement email))
          {
            Console.WriteLine($"{subscriber.GetProperty("Name")} has a valid email");
          }
          else
          {
            int id = subscriber.GetProperty("ID").GetInt32();
            subscribersWithMissingEmails.Add(id);
          }
        }
      }

      return subscribersWithMissingEmails;
    }
  }
}