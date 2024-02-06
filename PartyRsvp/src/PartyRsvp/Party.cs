namespace PartyRsvp;
public class Party
{
  static List<string> family = new List<string>() { "Harrison", "Kelsey", "Alex", "Haley" };
  static List<string> friends = new List<string>() { "James", "Hannah", "Kelly", "Alex" };
  static List<string> rsvp = new List<string>() { "Kelly", "Harrison" };

  static HashSet<string> invites = new HashSet<string>();

  public static void Main(string[] args)
  {
    // MARK: Setup
    Console.WriteLine("Hit ENTER to see your party invite breakdown!");
    Console.ReadKey();

    // MARK: Result
    InviteDetails();
    Console.ReadKey();
  }

  // MARK: Write your solution here
  public static void InviteDetails()
  {
    int invitesSent = GetTotalInvites();
    Console.WriteLine($"{invitesSent} total invites");
    HashSet<string> duplicates = GetDuplicates();
    string duplicateString = duplicates.Count > 1 ? "duplicates" : "duplicate";
    Console.Write($"{duplicates.Count} {duplicateString} -> ");
    PrintOnConsole(duplicates);
    Console.Write($"Missing RSVPs -> ");
    PrintOnConsole(GetMissingRsvps());
  }


  public static HashSet<string> GetMissingRsvps()
  {
    invites.ExceptWith(rsvp);
    return invites;
  }

  public static HashSet<string> GetDuplicates()
  {
    HashSet<string> duplicates = new HashSet<string>(family);
    duplicates.IntersectWith(friends);
    return duplicates;
  }

  public static int GetTotalInvites()
  {
    invites.UnionWith(family);
    invites.UnionWith(friends);
    return invites.Count;
  }

  public static void PrintOnConsole(HashSet<string> names)
  {
    foreach (string name in names)
    {
      Console.Write($"{name} ");
    }
    Console.WriteLine();
  }
}