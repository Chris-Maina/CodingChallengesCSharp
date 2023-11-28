namespace DecomposingUrls
{
  public class Program
  {
    public static void Main()
    {
      string[] urlParts = GetUrlParts("www.learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays");
      foreach (string part in urlParts)
      {
        Console.WriteLine(part);
      }
    }

    public static string[] GetUrlParts(string url)
    {
      if(string.IsNullOrEmpty(url) || string.IsNullOrWhiteSpace(url)) return new string[0];
      // remove wwww if present
      string worldWideWeb = "www";
      int worldWideWebIndex = url.IndexOf(worldWideWeb);
      if (worldWideWebIndex != -1) {
        url = url.Remove(worldWideWebIndex, worldWideWeb.Length + 1);
      }

      // remove hyphen
      int hyphenIndex = url.IndexOf("-");
      if (hyphenIndex != -1){
        url =  url.Replace("-", " ");
      }

      return url.Split("/", StringSplitOptions.RemoveEmptyEntries); ;
    }
  }
}
