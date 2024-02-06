namespace PartyRsvpTests;
using PartyRsvp;

[TestClass]
public class PartyTests
{
    [TestMethod]
    public void GetTotalInvites_Returns_Total()
    {
      Assert.AreEqual(Party.GetTotalInvites(), 7);
    }

    [TestMethod]
    public void GetDuplicates_Returns_Valid_Duplicates()
    {
      HashSet<string> duplicates = new HashSet<string>() { "Alex" };
      Assert.AreEqual(Party.GetDuplicates().Count, duplicates.Count);
    }

    [TestMethod]
    public void GetMissingRsvps_Returns_Missing_RSVPs()
    {
      HashSet<string> missing = new HashSet<string>() { "James", "Hannah", "Alex", "Kelsey", "Haley" };
      Assert.AreEqual(Party.GetMissingRsvps().Count, missing.Count);
    }
}