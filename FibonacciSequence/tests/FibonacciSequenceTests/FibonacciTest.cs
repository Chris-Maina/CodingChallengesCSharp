namespace FibonacciSequenceTests;
using FibonacciSequence;

[TestClass]
public class FibonacciSequenceTest
{

    [TestMethod]
    public void CalculateFibonacci_Returns_Valid_Integer_List()
    {
      List<int> result = Fibonacci.CalculateFibonacci(5);
      List<int> expected = new List<int> { 0, 1, 1, 2, 3 };
      CollectionAssert.AreEqual(expected, result);
    }

    [TestMethod]
    public void CalculateFibonacci_Result_Starts_With_ZeroAndOne()
    {
      List<int> result = Fibonacci.CalculateFibonacci(5);
      List<int> expected = new List<int> { 0, 1, 1, 2, 3 };
      Assert.AreEqual(result[0], 0);
      Assert.AreEqual(result[1], 1);
    }

    [TestMethod]
    public void CalculateFibonacci_Returns_Empty_List_When_Invoked_With_Zero()
    {
      List<int> result = Fibonacci.CalculateFibonacci(0);
      List<int> expected = new List<int>();
      CollectionAssert.AreEqual(result, expected);
    }

    [TestMethod]
    public void CalculateFibonacci_Returns_One_If_length_is_One()
    {
      List<int> result = Fibonacci.CalculateFibonacci(1);
      List<int> expected = new List<int> { 0 };
      CollectionAssert.AreEqual(result, expected);
    }
}