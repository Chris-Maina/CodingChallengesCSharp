using VowelCount;
namespace VowelCountTests;

[TestClass]
public class UnitTest1
{

    readonly CountVowels countVowels = new CountVowels();

    [TestMethod]
    public void GetVowelCount_Returns_Score()
    {
      int result = countVowels.GetVowelCount("Hey LinkedIn");
      Assert.AreEqual(result, 19);
    }

    [TestMethod]
    public void GetVowelCount_Returns_Zero_Score()
    {
    int result = countVowels.GetVowelCount("Psst");
    Assert.AreEqual(result, 0);
  }

}