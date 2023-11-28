namespace Tests;
using DecomposingUrls;

[TestClass]
public class UnitTest1
{
  private string _testUrl = "https://radio.or.ke/sound-city/";

  [TestMethod]
  public void GetUrlParts_Replaces_Hyphen_With_Space()
  {
    string[] expected = { "https:", "radio.or.ke", "sound city" };
    string[] actual = Program.GetUrlParts("https://radio.or.ke/sound-city/");

    Assert.AreEqual(actual, expected);
  }

  [TestMethod]
  public void GetUrlParts_Returns_Empty_Array_No_Url()
  {
    string[] expected = { };
    string[] actual = Program.GetUrlParts("");

    Assert.AreEqual(actual, expected);
    Assert.AreEqual(actual.Length, expected.Length);
  }

  [TestMethod]
  public void GetUrlParts_Removes_www()
  {
    string[] expected = {"radio.or.ke"};
    string[] actual = Program.GetUrlParts("www.radio.or.ke");

    Assert.AreEqual(actual, expected);
  }

  [TestMethod]
  public void GetUrlParts_Returns_reequired_parts()
  {
    string[] expected = { "google.com", "todo-list" };
    string[] actual = Program.GetUrlParts("www.google.com/todo-list");

    Assert.AreEqual(actual, expected);
  }
}