namespace Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmailValidation;

[TestClass]
public class EmailValidationTest
{
    [TestMethod]
    public void ValidateEmail_WithValidEmail_Returns_True()
    {
      // Arrange
      string actual = Program.ValidateEmail("tquinn@red30tech.com");
      // Assert
      Assert.AreEqual(actual, "Email is valid");
  }

    [TestMethod]
    public void ValidateEmail_WithEmailThatStartsWithNumber_Returns_False()
    {
      // Act
      string actual = Program.ValidateEmail("88tquinn@red30tech.com");

      // Assert
      Assert.AreEqual(actual, "Email can't start with a number or symbol");
    }

    [TestMethod]
    public void ValidateEmail_WithEmailNoAtSymbol_Returns_False()
    {
      string actual = Program.ValidateEmail("tquinnred30tech.com");
      Assert.AreEqual(actual, "Email must contain @ symbol.");

    }
    [TestMethod]
    public void ValidateEmail_WithEmailNoDotCom_Returns_False()
    {
      // Act
      string actual = Program.ValidateEmail("tquinn@red30tech");

      // Assert
      Assert.AreEqual(actual, "Email must end with .com.");
    }
}
