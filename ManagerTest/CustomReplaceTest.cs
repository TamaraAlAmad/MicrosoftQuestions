using BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ManagerTest
{
  /// <summary>
  /// Represent the test cases for custom replace method
  /// </summary>
  [TestClass]
  public class CustomReplaceTest
  {
    private CustomReplace CustomReplaceObject { get; }

    /// <summary>
    /// Default empty constructor.
    /// </summary>
    public CustomReplaceTest()
    {
      CustomReplaceObject = new CustomReplace();
    }

    /// <summary>
    /// Implementation of testing the below.
    /// 1. replace of same size string.
    /// 2. one replacement made.
    /// </summary>
    [TestMethod]
    public void CustomReplace_SameSizeStrings()
    {
      // Arange.
      string input = "Microsoft";
      string oldvalue = "ic";
      string newValue = "ab";

      // Act.
      int replacedCount = this.CustomReplaceObject.StringReplace(oldvalue, newValue,ref input);

      // Assert.
      Assert.AreEqual("Mabrosoft",input,"invalid replaced value.");
      Assert.AreEqual(1, replacedCount, "invalid replaced count.");
    }

    /// <summary>
    /// Implementation of testing the below.
    /// 1. replace of new value shorter than the new value.
    /// 2. one replacement made.
    /// </summary>
    [TestMethod]
    public void CustomReplace_NewStringShorterThanOldString()
    {
      // Arange.
      string input = "Microsoft";
      string oldvalue = "ic";
      string newValue = "a";

      // Act.
      int replacedCount = this.CustomReplaceObject.StringReplace(oldvalue, newValue, ref input);

      // Assert.
      Assert.AreEqual("Marosoft", input, "invalid replaced value.");
      Assert.AreEqual(1, replacedCount, "invalid replaced count.");
    }

    /// <summary>
    /// Implementation of testing the below.
    /// 1. replace of new value longer than the new value.
    /// 2. one replacement made.
    /// </summary>
    [TestMethod]
    public void CustomReplace_NewStringLongerThanOldString()
    {
      // Arange.
      string input = "Microsoft";
      string oldvalue = "ic";
      string newValue = "MSFT";

      // Act.
      int replacedCount = this.CustomReplaceObject.StringReplace(oldvalue, newValue, ref input);

      // Assert.
      Assert.AreEqual("MMSFTrosoft", input, "invalid replaced value.");
      Assert.AreEqual(1, replacedCount, "invalid replaced count.");
    }

    /// <summary>
    /// Implementation of testing the below.
    /// 1. replace of new value longer than the new value.
    /// 2. one replacement made.
    /// 3. egde replacement.
    /// </summary>
    [TestMethod]
    public void CustomReplace_NewStringLongerThanOldStringOnEdge()
    {
      // Arange.
      string input = "Microsoft";
      string oldvalue = "ft";
      string newValue = "abc";

      // Act.
      int replacedCount = this.CustomReplaceObject.StringReplace(oldvalue, newValue, ref input);

      // Assert.
      Assert.AreEqual("Microsoabc", input, "invalid replaced value.");
      Assert.AreEqual(1, replacedCount, "invalid replaced count.");
    }

    /// <summary>
    /// Implementation of testing the below.
    /// 1. replace of new value longer than the new value.
    /// 2. three replacement made.
    /// 3. egde replacement.
    /// </summary>
    [TestMethod]
    public void CustomReplace_MultiNewStringLongerThanOldStringOnEdge()
    {
      // Arange.
      string input = "MicrosoftMicrosoftMicrosoft";
      string oldvalue = "ft";
      string newValue = "abc";

      // Act.
      int replacedCount = this.CustomReplaceObject.StringReplace(oldvalue, newValue, ref input);

      // Assert.
      Assert.AreEqual("MicrosoabcMicrosoabcMicrosoabc", input, "invalid replaced value.");
      Assert.AreEqual(3, replacedCount, "invalid replaced count.");
    }

    /// <summary>
    /// Implementation of testing the below.
    /// 1. replace of new value same as new value.
    /// 2. one replacement made.
    /// 3. egde replacement.
    /// </summary>
    [TestMethod]
    public void CustomReplace_NewStringSameAsOldStringOnEdge()
    {
      // Arange.
      string input = "Microsoft";
      string oldvalue = "ft";
      string newValue = "ft";

      // Act.
      int replacedCount = this.CustomReplaceObject.StringReplace(oldvalue, newValue, ref input);

      // Assert.
      Assert.AreEqual("Microsoft", input, "invalid replaced value.");
      Assert.AreEqual(1, replacedCount, "invalid replaced count.");
    }

    /// <summary>
    /// Implementation of testing the below.
    /// 1. replace of new value same as the new value.
    /// 2. three replacement made.
    /// 3. egde replacement.
    /// </summary>
    [TestMethod]
    public void CustomReplace_NewStringMultiSameAsOldStringOnEdge()
    {
      // Arange.
      string input = "MicrosoftMicrosoftMicrosoft";
      string oldvalue = "ft";
      string newValue = "ft";

      // Act.
      int replacedCount = this.CustomReplaceObject.StringReplace(oldvalue, newValue, ref input);

      // Assert.
      Assert.AreEqual("MicrosoftMicrosoftMicrosoft", input, "invalid replaced value.");
      Assert.AreEqual(3, replacedCount, "invalid replaced count.");
    }

    /// <summary>
    /// Implementation of testing the below.
    /// 1. replace of new value longer than the new value.
    /// 2. four replacement made.
    /// 3. input with space values.
    /// </summary>
    [TestMethod]
    public void CustomReplace_NewStringMultiWithSpacesOldStringOnEdge()
    {
      // Arange.
      string input = "Microsoft Microsoft Microsoft Microsoft";
      string oldvalue = "oso";
      string newValue = "abcd";

      // Act.
      int replacedCount = this.CustomReplaceObject.StringReplace(oldvalue, newValue, ref input);

      // Assert.
      Assert.AreEqual("Micrabcdft Micrabcdft Micrabcdft Micrabcdft", input, "invalid replaced value.");
      Assert.AreEqual(4, replacedCount, "invalid replaced count.");
    }
  }
}
